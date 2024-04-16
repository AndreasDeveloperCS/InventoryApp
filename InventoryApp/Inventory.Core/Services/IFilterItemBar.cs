using Inventory.Core.InventoryModels;

namespace InventoryCore.Services
{
    public interface IFilterItemBar : IFilter<InventoryItem>
    {
        string Type { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        int Quantity { get; set; }

        bool IsRoadVehicle { get; set; }
    }
}
