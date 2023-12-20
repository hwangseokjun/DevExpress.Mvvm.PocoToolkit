using DevExpress.Mvvm.PocoToolkit.Main.UI.Views;
using DevExpress.Mvvm.PocoToolkit.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.Demo.Properties
{
    internal class RegionModule : RegionModuleBase
    {
        protected override void Register(RegionCollection regionCollection)
        {
            regionCollection.Register<MainContent>("MainRegion", "MainContent");
        }
    }
}
