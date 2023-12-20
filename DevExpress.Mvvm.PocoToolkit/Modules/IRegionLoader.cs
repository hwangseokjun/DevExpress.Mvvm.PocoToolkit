using DevExpress.Mvvm.ModuleInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.Modules
{
    public interface IRegionLoader
    {
        void OnLoaded(IModuleManager moduleManager);
    }
}
