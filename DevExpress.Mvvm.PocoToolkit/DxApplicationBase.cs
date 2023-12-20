using DevExpress.Mvvm.PocoToolkit.Commons;
using DevExpress.Mvvm.PocoToolkit.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DevExpress.Mvvm.PocoToolkit
{
    public abstract class DxApplicationBase : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureDIContainer();
            OnInitializing();
            OnInitialized();
        }

        protected virtual void ConfigureDIContainer()
        {
            DIContainer.Build();
        }

        protected virtual void OnInitializing()
        {
            Window shell = CreateShell();

            if (shell != null)
            {
                AutoWireHelper.AutoWireViewModel(shell);
                InitializeShell(shell);
            }
        }

        private void InitializeShell(Window shell)
        {
            MainWindow = shell;
        }

        protected virtual void OnInitialized()
        {
            MainWindow?.Show();
        }

        protected abstract Window CreateShell();
    }
}
