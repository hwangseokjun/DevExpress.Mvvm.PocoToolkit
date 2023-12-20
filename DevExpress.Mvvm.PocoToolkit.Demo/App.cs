using DevExpress.Mvvm.PocoToolkit.Demo.Common.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DevExpress.Mvvm.PocoToolkit.Demo
{
    internal class App : DxApplication
    {
        protected override Window CreateShell()
        {
            return new CustomWindow();
        }
    }
}
