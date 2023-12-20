using DevExpress.Mvvm.ModuleInjection;
using DevExpress.Mvvm.PocoToolkit.IoC;
using DevExpress.Mvvm.PocoToolkit.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DevExpress.Mvvm.PocoToolkit
{
    public static class ViewModelLocator
    {
        public static readonly DependencyProperty AutoWireViewModelProperty =
            DependencyProperty.RegisterAttached("AutoWireViewModel", typeof(bool?), typeof(ViewModelLocator), new PropertyMetadata(OnAutoWireViewModelChanged));

        public static bool? GetAutoWireViewModel(DependencyObject obj)
        {
            return (bool?)obj.GetValue(AutoWireViewModelProperty);
        }

        public static void SetAutoWireViewModel(DependencyObject obj, bool? value)
        {
            obj.SetValue(AutoWireViewModelProperty, value);
        }

        private static void OnAutoWireViewModelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!DesignerProperties.GetIsInDesignMode(d))
            {
                var value = (bool?)e.NewValue;

                if (value.HasValue && value.Value)
                {
                    ViewModelLocatorProvider.AutoWireViewModelChanged(d, Bind);
                    ViewModelLocatorProvider.AutoWireViewModelChanged(d, LoadRegionIfNeeded);
                }
            }
        }

        private static void Bind(object view, object viewModel)
        {
            if (view is FrameworkElement element)
            {
                element.DataContext = viewModel;
            }
        }

        private static void LoadRegionIfNeeded(object view, object viewModel)
        {
            if (viewModel is IRegionLoader && view is FrameworkElement element)
            {
                element.Loaded += Element_Loaded;
            }
        }

        private static void Element_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element
                && element.DataContext is IRegionLoader loader)
            {
                element.Loaded -= Element_Loaded;
                loader.OnLoaded(ModuleManager.DefaultManager);
            }
        }
    }
}
