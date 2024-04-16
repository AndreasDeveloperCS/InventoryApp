using InventoryApp.Views;
using Prism.Ioc;
using Prism.Unity;
using System.Windows;
using Unity;

namespace BootstrapperShell
{
    class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
