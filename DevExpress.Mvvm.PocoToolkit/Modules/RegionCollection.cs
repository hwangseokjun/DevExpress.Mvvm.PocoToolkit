using DevExpress.Mvvm.ModuleInjection;
using DevExpress.Mvvm.PocoToolkit.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.Modules
{
    public class RegionCollection
    {
        public void Register<TView>(string regionName, string key)
        {
            ModuleManager.DefaultManager.Register(
                regionName,
                new Module(key, () => ViewModelLocatorProvider.Resolve<TView>(),
                typeof(TView)));
        }
    }
}
