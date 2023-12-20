using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.IoC
{
    internal static class ViewModelLocatorProvider
    {
        private static readonly Dictionary<string, Type> _factories = new Dictionary<string, Type>();

        public static void AutoWireViewModelChanged(object view, Action<object, object> setDataContextCallback) 
        {
            object viewModel = GetViewModelForView(view);
            setDataContextCallback(view, viewModel);
        }

        private static object GetViewModelForView(object view)
        {
            string viewKey = view.GetType().ToString();

            if (_factories.ContainsKey(viewKey)) 
            {
                Type viewModelType = _factories[viewKey];
                return DIContainer.Resolve(viewModelType);
            }

            return null;
        }

        public static object Resolve<T>() 
        {
            string viewKey = typeof(T).ToString();

            if (_factories.ContainsKey(viewKey)) 
            {
                Type viewModelType = _factories[viewKey];
                return DIContainer.Resolve(viewModelType);
            }

            return null;
        }

        public static void Register<V, VM>() 
        {
            Type viewType = typeof(V);
            Type viewModelType = typeof(VM);
            _factories[viewType.ToString()] = viewModelType;
            DIContainer.RegisterSingleton(viewModelType, ViewModelSource.GetPOCOType(viewModelType));
        }
    }
}
