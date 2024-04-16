using InventoryApp.Interfaces;
using Prism.Events;

namespace InventoryApp.ViewModels.ContentType
{
    public class BoatContentViewModel : ContentViewModel, IContentViewModel
    {
        public BoatContentViewModel(IEventAggregator aggregator) : base(aggregator) { }
    }
}
