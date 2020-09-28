// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationPerformanceTestModels.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Runtime.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Runtime.Serialization;
    using Catel.Data;

    public enum IniEntryType
    {
        Public,

        Private
    }

    [Serializable]
    public class IniEntry : SavableModelBase<IniEntry>
    {
        #region Fields
        #endregion

        #region Constructors
        public IniEntry()
        {
        }

#if CATEL_5
        protected IniEntry(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
        #endregion

        #region Properties
        public string Group { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public IniEntryType IniEntryType { get; set; }
        #endregion
    }

    [Serializable]
    public class IniFile : SavableModelBase<IniFile>
    {
        #region Fields
        #endregion

        #region Constructors
        public IniFile()
        {
            IniEntryCollection = new List<IniEntry>();
        }

#if CATEL_5
        protected IniFile(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
        #endregion

        #region Properties
        public string FileName { get; set; }

        public List<IniEntry> IniEntryCollection { get; set; }
        #endregion
    }

    [Serializable]
    public class ComputerSettings : SavableModelBase<ComputerSettings>
    {
        #region Fields
        #endregion

        #region Constructors
        public ComputerSettings()
        {
            IniFileCollection = InitializeDefaultIniFileCollection();
        }

#if CATEL_5
        protected ComputerSettings(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
        #endregion

        #region Properties
        public string ComputerName { get; set; }

        public ObservableCollection<IniFile> IniFileCollection { get; set; }
        #endregion

        #region Methods
        /// <summary>
        ///   Initializes the default ini file collection.
        /// </summary>
        /// <returns>New <see cref = "ObservableCollection{T}" />.</returns>
        private static ObservableCollection<IniFile> InitializeDefaultIniFileCollection()
        {
            var result = new ObservableCollection<IniFile>();

            // Add 3 files
            result.Add(ModelBaseTestHelper.CreateIniFileObject("Initial file 1", new[] { ModelBaseTestHelper.CreateIniEntryObject("G1", "K1", "V1") }));
            result.Add(ModelBaseTestHelper.CreateIniFileObject("Initial file 2", new[] { ModelBaseTestHelper.CreateIniEntryObject("G2", "K2", "V2") }));
            result.Add(ModelBaseTestHelper.CreateIniFileObject("Initial file 3", new[] { ModelBaseTestHelper.CreateIniEntryObject("G3", "K3", "V3") }));

            return result;
        }
        #endregion
    }

    public abstract class ModelBaseTestHelper
    {
        public static IniEntry CreateIniEntryObject(string group, string key, string value)
        {
            return new IniEntry
            {
                Group = group,
                Key = key,
                Value = value
            };
        }

        public static IniEntry CreateIniEntryObject()
        {
            var iniEntryObject = CreateIniEntryObject("MyGroup", "MyKey", "MyValue");
            iniEntryObject.IniEntryType = IniEntryType.Private;

            return iniEntryObject;
        }

        public static IniFile CreateIniFileObject(string fileName, IEnumerable<IniEntry> iniEntries)
        {
            var iniFile = new IniFile
            {
                FileName = fileName
            };

            foreach (var iniEntry in iniEntries)
            {
                iniFile.IniEntryCollection.Add(iniEntry);
            }

            return iniFile;
        }

        public static IniFile CreateIniFileObject()
        {
            var iniEntries = new List<IniEntry>();

            for (int i = 0; i < 3; i++)
            {
                var iniEntry = CreateIniEntryObject(string.Format("Group {0}", i),
                                                    string.Format("Key {0}", i),
                                                    string.Format("Value {0}", i));

                iniEntry.IniEntryType = (i % 2 == 0) ? IniEntryType.Public : IniEntryType.Private;

                iniEntries.Add(iniEntry);
            }

            return CreateIniFileObject("MyIniFile", iniEntries);
        }

        public static ComputerSettings CreateComputerSettingsObject(string computerName, IEnumerable<IniFile> iniFiles)
        {
            var computerSettings = new ComputerSettings
            {
                ComputerName = computerName
            };

            foreach (var iniFile in iniFiles)
            {
                computerSettings.IniFileCollection.Add(iniFile);
            }

            return computerSettings;
        }

        public static ComputerSettings CreateComputerSettingsObject()
        {
            var iniFiles = new List<IniFile>();

            for (int i = 0; i < 3; i++)
            {
                var iniFile = CreateIniFileObject();
                iniFile.FileName = string.Format("MyFile {0}", i);
                iniFiles.Add(iniFile);
            }

            return CreateComputerSettingsObject("MyComputer", iniFiles);
        }
    }
}
