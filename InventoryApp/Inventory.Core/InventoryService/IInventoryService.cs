using Inventory.Core.InventoryModels;

namespace Inventory.Core.InventoryService
{
    public interface IInventoryService
    {
        IEnumerable<InventoryItem> GetItems();
    }

}
