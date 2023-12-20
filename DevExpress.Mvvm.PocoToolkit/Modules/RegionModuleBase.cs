using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.Modules
{
    public abstract class RegionModuleBase
    {
        internal void Publish()
        {
            var regions = new RegionCollection();
            Register(regions);
        }

        protected abstract void Register(RegionCollection regionCollection);
    }
}
