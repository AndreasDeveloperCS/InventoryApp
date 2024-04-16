using Inventory.Core.InventoryModels;
using Inventory.Core.InventoryService;
using InventoryApp.Events;
using InventoryApp.Interfaces;
using Prism.Events;
using System.Collections.ObjectModel;

namespace InventoryApp.ViewModels
{
    internal class InventoryCollectionViewModel : ViewModelBase, IInventoryCollectionViewModel
    {
        private ObservableCollection<InventoryItem> _inventoryCollection = new ObservableCollection<InventoryItem>();
        private InventoryItem _selectedInventoryItem;
        private string _title;
        private readonly IInventoryService _inventoryService;

        public InventoryCollectionViewModel(IEventAggregator aggregator,
                                            IInventoryService inventoryService) : base(aggregator)
        {
            _inventoryService = inventoryService;
            Populate();
        }

        void Populate()
        {
            foreach (var item in _inventoryService.GetItems())
            {
                InventoryCollection.Add(item);
            }
        }

        public InventoryItem SelectedInventoryItem
        {
            get => _selectedInventoryItem;
            set
            {
                if (_selectedInventoryItem == value)
                {
                    return;
                }

                _selectedInventoryItem = value;
                Aggregator.GetEvent<SelectionChangedEvent>().Publish(_selectedInventoryItem);
                OnPropertyChanged();
            }
        }

        public ObservableCollection<InventoryItem> InventoryCollection 
        { 
            get =>  _inventoryCollection ?? (_inventoryCollection = new ObservableCollection<InventoryItem>());
            set
            {
                if (_inventoryCollection == value)
                {
                    return;
                }

                _inventoryCollection = value;
                OnPropertyChanged();
            }
        }
    }
}
