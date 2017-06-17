namespace Catel.Benchmarks.IoC
{
    using Catel.IoC;

    public class NoRequirePropertyInjection
    {
        #region Constructors
        public NoRequirePropertyInjection()
        {
        }

        public NoRequirePropertyInjection(string param)
        {
        }

        public NoRequirePropertyInjection(string param, IServiceLocator serviceLocator)
        {
        }
        #endregion
    }
}