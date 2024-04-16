
using Prism.Events;
using System;

namespace InventoryApp.ViewModels
{
    public class ViewModelBase : NotifiableViewModel, IDisposable
    {
        private bool _isActive;

        protected IEventAggregator Aggregator { get; }

        public ViewModelBase(IEventAggregator aggregator)
        {
            Aggregator = aggregator;
        }

        protected virtual  void SwitchIsActive(bool isActive)
        {
            IsActive = !IsActive;
        }

        public virtual void SaveToDatabase()
        {
            
        }

        public bool IsActive
        {
            get => _isActive;
            set
            {
                if (value == _isActive)
                {
                    return;
                }

                _isActive = value;
                OnPropertyChanged();
            }
        }
        protected virtual void Dispose(bool isDisposed)
        {

        }

        public void Dispose()
        {
            Dispose(false);
        }

    }
}
