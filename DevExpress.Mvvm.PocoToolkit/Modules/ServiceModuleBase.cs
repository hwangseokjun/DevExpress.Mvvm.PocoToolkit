using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.Mvvm.PocoToolkit.Modules
{
    public abstract class ServiceModuleBase
    {
        internal void Publish()
        {
            var services = new ServiceCollection();
            Register(services);
        }

        protected abstract void Register(ServiceCollection serviceCollection);
    }
}
