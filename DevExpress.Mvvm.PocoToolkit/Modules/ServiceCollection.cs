using DevExpress.Mvvm.PocoToolkit.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.Modules
{
    public class ServiceCollection
    {
        public void Register<T>()
        {
            DIContainer.Register(typeof(T));
        }

        public void RegisterSingleton<T>()
        {
            DIContainer.RegisterSingleton(typeof(T));
        }

        public void Register<TService, TImplementation>()
        {
            DIContainer.Register(typeof(TService), typeof(TImplementation));
        }

        public void RegisterSingleton<TService, TImplementation>()
        {
            DIContainer.RegisterSingleton(typeof(TService), typeof(TImplementation));
        }
    }
}
