using DevExpress.Mvvm.ModuleInjection;
using DevExpress.Mvvm.PocoToolkit.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DevExpress.Mvvm.PocoToolkit.Controls
{
    public class DxRegion : ContentControl
    {
        public static readonly DependencyProperty RegionNameProperty =
            DependencyProperty.Register(nameof(RegionName), typeof(string), typeof(DxRegion));

        public string RegionName
        {
            get => (string)GetValue(RegionNameProperty);
            set => SetValue(RegionNameProperty, value);
        }

        static DxRegion()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DxRegion),
                new FrameworkPropertyMetadata(typeof(DxRegion)));
        }

        public DxRegion()
        {
            Loaded += DxRegion_Loaded;
        }

        private void DxRegion_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is IRegionLoader loader)
            {
                Loaded -= DxRegion_Loaded;
                loader.OnLoaded(ModuleManager.DefaultManager);
            }
        }
    }
}
