using Inventory.Core.InventoryModels;

namespace InventoryApp.Interfaces
{
    public interface IContentViewModel
    {
        public InventoryItem SelectedInventoryItem { get; set; }
    }
}
