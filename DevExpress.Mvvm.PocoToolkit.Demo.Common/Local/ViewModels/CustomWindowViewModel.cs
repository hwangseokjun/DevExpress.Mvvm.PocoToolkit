using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.ModuleInjection;
using DevExpress.Mvvm.PocoToolkit.Demo.Common.Local.Services;
using DevExpress.Mvvm.PocoToolkit.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DevExpress.Mvvm.PocoToolkit.Demo.Common.Local.ViewModels
{
    [POCOViewModel]
    public class CustomWindowViewModel : IRegionLoader
    {
        public CustomWindowViewModel(MyService myService)
        {
            if (myService != null) 
            {
                MessageBox.Show("inject success");
            }
        }

        public void OnLoaded(IModuleManager moduleManager)
        {
            moduleManager.Inject("MainRegion", "MainContent");
        }
    }
}
