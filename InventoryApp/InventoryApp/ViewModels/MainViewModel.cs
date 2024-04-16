using InventoryApp.Interfaces;
using Prism.Events;

namespace InventoryApp.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase, IMainWindowViewModel
    {
        private IInventoryCollectionViewModel _inventoryCollectionViewModel;
        private IContentViewModel _contentViewModel;
        private string _title;

        public MainWindowViewModel(
            IEventAggregator aggregator,
            IInventoryCollectionViewModel inventoryCollectionViewModel,
             IContentViewModel contentViewModel) : base(aggregator)
        {
            ContentViewModel = contentViewModel;
            InventoryCollectionViewModel = inventoryCollectionViewModel;
            TitleMain = "Inventory";
        }

        public IInventoryCollectionViewModel InventoryCollectionViewModel
        {
            get => _inventoryCollectionViewModel;
            set
            {
                if (_inventoryCollectionViewModel == value)
                {
                    return;
                }

                _inventoryCollectionViewModel = value;
           
                OnPropertyChanged();
            }
        }

        public IContentViewModel ContentViewModel
        {
            get => _contentViewModel;
            set
            {
                if (_contentViewModel == value)
                {
                    return;
                }

                _contentViewModel = value;
                OnPropertyChanged();
            }
        }

        public string TitleMain
        {
            get => _title;
            set
            {
                if (_title == value)
                {
                    return;
                }

                _title = value;

                OnPropertyChanged();
            }
        }
    }
}
