using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DevExpress.Mvvm.PocoToolkit.Main.UI.Views
{
    public class MainContent : ContentControl
    {
        static MainContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainContent),
                new FrameworkPropertyMetadata(typeof(MainContent)));
        }
    }
}
