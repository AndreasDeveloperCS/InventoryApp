using Inventory.Core.InventoryModels;
using Inventory.Core.Commands;
using InventoryApp.Events;
using InventoryApp.Interfaces;
using Prism.Events;
using System;
using System.Windows.Input;
using System.Windows;

namespace InventoryApp.ViewModels
{
    public class ContentViewModel : ViewModelBase, IContentViewModel
    {
        private InventoryItem _selectedInventoryItem;
        private int _currentQuanityInput = 0;
        private string _warning;
        private ICommand _changeQunatityCommand;
        private string _currentQuanityInputString;

        public ContentViewModel(IEventAggregator aggregator) : base(aggregator)
        {
            Aggregator.GetEvent<SelectionChangedEvent>().Subscribe(UpdateContent);
            ChangeQunatityCommand = new RelayCommand(ChangeQunatityExecute, ChangeQunatityCanExecute);
        }

        public ICommand ChangeQunatityCommand
        {
            get { return _changeQunatityCommand; }
            set
            {
                _changeQunatityCommand = value;
                OnPropertyChanged(nameof(ChangeQunatityCommand));
                // Update the CanExecute state when the command changes
                OnPropertyChanged(nameof(CanExecuteChangeQunatityCommand));
            }
        }

        public bool CanExecuteChangeQunatityCommand
        {
            get { return ChangeQunatityCommand?.CanExecute(null) ?? false; }
        }
        private void ChangeQunatityExecute(object parameter)
        {
            SelectedInventoryItem.Quantity = _currentQuanityInput;
            MessageBox.Show($"Quantity has been changed {parameter}");
        }

        private bool ChangeQunatityCanExecute(object parameter)
        {
            return string.IsNullOrEmpty(Warning); 
        }

        public string QuanityInput
        {
            get => _currentQuanityInputString;
            set
            {
                if (SelectedInventoryItem.Quantity.ToString() == value)
                {
                    return;
                }
                _currentQuanityInputString = value;
                int quantity = Validate(value);
                _currentQuanityInput = quantity;
              
                OnPropertyChanged();
            }
        }

        private int Validate(string value)
        {
            try
            {
                int intValue = Convert.ToInt32(value);
                if(intValue < 0)
                {
                    Warning = "Quantity should equal 0 or more";
                    return _currentQuanityInput;
                }
                if(intValue >= 0)
                {
                    Warning = "";
                }
                return intValue;

            }
            catch (Exception ex) {
                Warning = "Quantity should be integer number more than 0";
                return _currentQuanityInput;
            }
        }

        public string Warning
        {
            get => _warning;
            set
            {
                if (_warning == value)
                {
                    return;
                }
                _warning = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }


        private void UpdateContent(InventoryItem inventoryItem)
        {
            SelectedInventoryItem = inventoryItem;
        }

        protected override void Dispose(bool isDisposed)
        {
            Aggregator.GetEvent<SelectionChangedEvent>().Unsubscribe(UpdateContent);
            base.Dispose(isDisposed);
        }
    }
}
