using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DevExpress.Mvvm.PocoToolkit.Commons
{
    internal static class AutoWireHelper
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void AutoWireViewModel(object viewOrViewModel)
        {
            if (viewOrViewModel is FrameworkElement view
                && view.DataContext is null
                && ViewModelLocator.GetAutoWireViewModel(view) is null)
            {
                ViewModelLocator.SetAutoWireViewModel(view, true);
            }
        }
    }
}
