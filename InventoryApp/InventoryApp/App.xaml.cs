using Inventory.Core.InventoryService;
using Inventory.Data.InventoryService;
using InventoryApp.Interfaces;
using InventoryApp.ViewModels;
using InventoryApp.Views;
using Prism.Ioc;
using Prism.Unity;
using System.Windows;

namespace InventoryApp
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IInventoryService, InventoryService>();
            containerRegistry.Register<IInventoryCollectionViewModel, InventoryCollectionViewModel>();
            containerRegistry.Register<IContentViewModel, ContentViewModel>();
        }
    }
}
