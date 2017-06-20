namespace Catel.Benchmarks.IoC
{
    public class ServiceB : IServiceB
    {
        #region Constructors
        public ServiceB(IServiceA serviceA)
        {
        }
        #endregion
    }
}