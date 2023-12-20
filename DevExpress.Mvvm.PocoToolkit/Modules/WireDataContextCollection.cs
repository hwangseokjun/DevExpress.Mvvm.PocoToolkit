using DevExpress.Mvvm.PocoToolkit.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.Modules
{
    public class WireDataContextCollection
    {
        public void Register<V, VM>()
        {
            ViewModelLocatorProvider.Register<V, VM>();
        }
    }
}
