using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.Modules
{
    public abstract class WireDataContextBase
    {
        internal void Publish()
        {
            var wires = new WireDataContextCollection();
            Register(wires);
        }

        protected abstract void Register(WireDataContextCollection wireDataContextCollection);
    }
}
