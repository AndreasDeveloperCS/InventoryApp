namespace Inventory.Core.InventoryModels
{
    public class InventoryItem
    {
        public InventoryItem(Vehicle vehicle, int quantity)
        {
            Vehicle = vehicle;
            Quantity = quantity;
        }

        public int Quantity { get; set; }
        public Vehicle Vehicle { get; private set; }

    }

}
