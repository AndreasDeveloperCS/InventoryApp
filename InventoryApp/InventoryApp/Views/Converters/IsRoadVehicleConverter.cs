using Inventory.Core.InventoryModels;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace InventoryApp.Views.Converters
{
    class IsRoadVehicleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try { 
                switch (value.GetType())
                {
                    case Type vehicleType when vehicleType == typeof(Car):
                        return true;
                    case Type vehicleType when vehicleType == typeof(Aeroplane):
                        return false;
                    case Type vehicleType when vehicleType == typeof(Boat):
                        return false;
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                //ToDo: Logging
                MessageBox.Show(ex.Message);

                return value;   
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return false;
        }
        
    }
}
