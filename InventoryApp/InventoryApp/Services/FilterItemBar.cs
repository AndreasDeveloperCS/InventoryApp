using Inventory.Core.InventoryModels;
using InventoryApp.ViewModels;
using InventoryCore.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace InventoryApp.Services
{
    public class FilterItemBar : NotifiableViewModel, IFilterItemBar
    {
       
        private string _type;
        private string _make;
        private string _model;
        private int _quantity;
        private bool _isRoadVehicle;

        public FilterItemBar(Action filterAction)
        {
            FilterAction = filterAction;
        }

        private Action FilterAction { get; }



        public string Type 
        {
            get { return _type; }
            set
            {
                if (_type == value)
                {
                    return;
                }

                _type = value;
                OnPropertyChanged();
                FilterAction.Invoke();
            }
        }

        public string Make 
        {
            get { return _make; }
            set
            {
                if (_make == value)
                {
                    return;
                }

                _make = value;
                OnPropertyChanged();
                FilterAction.Invoke();
            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                if (_model == value)
                {
                    return;
                }

                _model = value;
                OnPropertyChanged();
                FilterAction.Invoke();
            }
        }
  
        public int WheelQuantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity == value)
                {
                    return;
                }

                _quantity = value;
                OnPropertyChanged();
                FilterAction.Invoke();
            }
        }
        public bool IsRoadVehicle
        {
            get { return _isRoadVehicle; }
            set
            {
                if (_isRoadVehicle == value)
                {
                    return;
                }

                _isRoadVehicle = value;
                OnPropertyChanged();
                FilterAction.Invoke();
            }
        }

        private IEnumerable<InventoryItem> FilterCollectionInternal(Collection<InventoryItem> generalList, CancellationToken token)
        {
            foreach (InventoryItem item in generalList)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }

                if (IsMatched(item))
                {
                    yield return item;
                }
            }
        }

        private bool IsMatched(InventoryItem item)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                //ToDo: Add Logging
                MessageBox.Show(ex.Message + ex.StackTrace.FirstOrDefault());
                throw;
            }
        }

        public IEnumerable<InventoryItem> FilterCollection(Collection<InventoryItem> generalList) => 
            generalList.Where(IsMatched);

        public async Task<IEnumerable<InventoryItem>> FilterCollectionAsync(Collection<InventoryItem> generalList,                                                                         CancellationToken token)
        {
            return await Task.Run(() => FilterCollectionInternal(generalList, token), token);
        }
    }
}
