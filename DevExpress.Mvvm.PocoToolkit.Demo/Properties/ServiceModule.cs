using DevExpress.Mvvm.PocoToolkit.Demo.Common.Local.Services;
using DevExpress.Mvvm.PocoToolkit.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.Demo.Properties
{
    internal class ServiceModule : ServiceModuleBase
    {
        protected override void Register(ServiceCollection serviceCollection)
        {
            serviceCollection.RegisterSingleton<MyService>();
        }
    }
}
