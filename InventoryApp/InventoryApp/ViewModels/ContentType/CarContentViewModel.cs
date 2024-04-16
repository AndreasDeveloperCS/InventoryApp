using InventoryApp.Interfaces;
using Prism.Events;

namespace InventoryApp.ViewModels.ContentType
{
    public class CarContentViewModel : ContentViewModel, IContentViewModel
    {
        public CarContentViewModel(IEventAggregator aggregator) : base(aggregator) { }
    }
}
