using Inventory.Core.InventoryModels;
using System.Collections.ObjectModel;

namespace InventoryApp.Interfaces
{
    public interface IInventoryCollectionViewModel
    {
        public InventoryItem SelectedInventoryItem { get; set; }

        public ObservableCollection<InventoryItem> InventoryCollection { get; set; }
    }
}
