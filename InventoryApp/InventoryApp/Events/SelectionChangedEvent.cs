using Inventory.Core.InventoryModels;
using Prism.Events;

namespace InventoryApp.Events
{
    public class SelectionChangedEvent : PubSubEvent<InventoryItem> { }
}
