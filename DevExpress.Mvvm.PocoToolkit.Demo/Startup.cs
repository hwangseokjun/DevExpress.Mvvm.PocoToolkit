using DevExpress.Mvvm.PocoToolkit.Demo.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.Demo
{
    internal class Startup
    {
        [STAThread]
        static void Main(string[] args)
        {
            _ = new App()
                .RegisterServices<ServiceModule>()
                .RegisterRegions<RegionModule>()
                .RegisterWireDataContext<WireDataContext>()
                .Run();
        }
    }
}
