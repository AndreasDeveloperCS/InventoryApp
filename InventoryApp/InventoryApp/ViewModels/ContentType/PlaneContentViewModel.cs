using InventoryApp.Interfaces;
using Prism.Events;

namespace InventoryApp.ViewModels.ContentType
{
    public class PlaneContentViewModel : ContentViewModel, IContentViewModel
    {
        public PlaneContentViewModel(IEventAggregator aggregator) : base(aggregator) { }
    }
}
