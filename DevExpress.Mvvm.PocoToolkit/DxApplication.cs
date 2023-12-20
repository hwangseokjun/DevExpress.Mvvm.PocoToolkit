using DevExpress.Mvvm.PocoToolkit.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DevExpress.Mvvm.PocoToolkit
{
    public abstract class DxApplication : DxApplicationBase
    {
        private readonly List<ServiceModuleBase> _serviceModules;
        private readonly List<RegionModuleBase> _regionModules;

        public DxApplication()
        {
            _serviceModules = new List<ServiceModuleBase>();
            _regionModules = new List<RegionModuleBase>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _serviceModules.ForEach(service => service.Publish());
            _regionModules.ForEach(region => region.Publish());
            base.OnStartup(e);
        }

        public DxApplication RegisterServices<T>() where T : ServiceModuleBase, new()
        {
            ServiceModuleBase service = new T();
            _serviceModules.Add(service);
            return this;
        }

        public DxApplication RegisterRegions<T>() where T : RegionModuleBase, new()
        {
            RegionModuleBase region = new T();
            _regionModules.Add(region);
            return this;
        }

        public DxApplication RegisterWireDataContext<T>() where T : WireDataContextBase, new()
        {
            WireDataContextBase wireDataContext = new T();
            wireDataContext.Publish();
            return this;
        }
    }
}
