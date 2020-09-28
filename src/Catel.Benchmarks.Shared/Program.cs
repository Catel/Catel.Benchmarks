// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using System.IO;
    using System.Linq;
    using BenchmarkDotNet.Running;
    using System.Collections.Generic;
    using System;
    using BenchmarkDotNet.Attributes;
    using Catel.Reflection;
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Jobs;
    using BenchmarkDotNet.Environments;
    using BenchmarkDotNet.Toolchains.InProcess.Emit;

    public static class Program
    {
        public static void Main(string[] args)
        {
            var benchmarkTypes = new List<Type>();
            var allTypes = typeof(Program).Assembly.GetAllTypesSafely();

            foreach (var type in allTypes)
            {
                if (!type.IsClassEx() || type.IsAbstractEx())
                {
                    continue;
                }

                var methods = type.GetMethodsEx();

                foreach (var method in methods)
                {
                    //if (method.IsDecoratedWithAttribute(typeof(Benchmark)))
                    if (method.CustomAttributes.Any(x => x.AttributeType == typeof(BenchmarkAttribute)))
                    {
                        benchmarkTypes.Add(type);
                        break;
                    }
                }
            }

            var config = new BenchmarkConfig()
                .AddJob(Job.Default
#if CATEL_5 && !CATEL_5_12
                    .WithRuntime(ClrRuntime.Net47)
#else
                    .WithToolchain(InProcessEmitToolchain.Instance)
                    .WithRuntime(CoreRtRuntime.CoreRt31)
#endif
                    .WithLaunchCount(3)
                    .WithWarmupCount(2)
                    .WithInvocationCount(16 * 150) // must be multiply of unroll factor
                    .WithUnrollFactor(16));

            //BenchmarkSwitcher
            //    .FromAssembly(typeof(Program).Assembly)
            //    .Run(args, config);

            foreach (var type in benchmarkTypes)
            {
                BenchmarkRunner.Run(type, config);
            }

            CopyArtifacts();
        }

        private static void CopyArtifacts()
        {
            var tempOutputFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BenchmarkDotNet.Artifacts");
            if (!Directory.Exists(tempOutputFolder))
            {
                tempOutputFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "BenchmarkDotNet.Artifacts");
            }

            var resultsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "results", IdentifierHelper.GetIdentifier());
            resultsFolder = Path.GetFullPath(resultsFolder);

            CopyDirectory(tempOutputFolder, resultsFolder);
        }

        private static void CopyDirectory(string source, string target)
        {
            Directory.CreateDirectory(target);

            foreach (var sourceFile in Directory.GetFiles(source, "*", SearchOption.TopDirectoryOnly))
            {
                var fileInfo = new FileInfo(sourceFile);

                var targetFile = Path.Combine(target, fileInfo.Name);

                File.Copy(sourceFile, targetFile, true);
            }

            foreach (var directory in Directory.GetDirectories(source, "*", SearchOption.TopDirectoryOnly))
            {
                var directoryInfo = new DirectoryInfo(directory);

                var targetDirectory = Path.Combine(target, directoryInfo.Name);

                CopyDirectory(directory, targetDirectory);
            }
        }
    }
}
