using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.IoC
{
    internal static class DIContainer
    {
        private static IServiceProvider _serviceProvider;
        private static IServiceCollection _services;

        static DIContainer()
        {
            _services = new ServiceCollection();
        }

        internal static void Register(Type type)
        {
            _services = _services.AddTransient(type);
        }

        internal static void RegisterSingleton(Type type)
        {
            _services = _services.AddSingleton(type);
        }

        internal static void Register(Type service, Type implementation)
        {
            _services = _services.AddTransient(service, implementation);
        }

        internal static void RegisterSingleton(Type service, Type implementation)
        {
            _services = _services.AddSingleton(service, implementation);
        }

        internal static object Resolve(Type type)
        {
            return _serviceProvider.GetRequiredService(type);
        }

        internal static void Build()
        {
            _serviceProvider = _services.BuildServiceProvider();
        }
    }
}
