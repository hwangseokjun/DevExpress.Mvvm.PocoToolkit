using DevExpress.Mvvm.PocoToolkit.Demo.Common.Local.ViewModels;
using DevExpress.Mvvm.PocoToolkit.Demo.Common.UI.Views;
using DevExpress.Mvvm.PocoToolkit.Main.Local.ViewModels;
using DevExpress.Mvvm.PocoToolkit.Main.UI.Views;
using DevExpress.Mvvm.PocoToolkit.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.Demo.Properties
{
    internal class WireDataContext : WireDataContextBase
    {
        protected override void Register(WireDataContextCollection wireDataContextCollection)
        {
            wireDataContextCollection.Register<MainContent, MainContentViewModel>();
            wireDataContextCollection.Register<CustomWindow, CustomWindowViewModel>();
        }
    }
}
