using Inventory.Core.InventoryModels;
using System;
using System.Globalization;
using System.Windows.Data;

namespace InventoryApp.Views.Converters
{
    public class VehicleTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.GetType())
            {
                case Type vehicleType when vehicleType == typeof(Car):
                    return "Car";
                case Type vehicleType when vehicleType == typeof(Aeroplane):
                    return "Plane";
                case Type vehicleType when vehicleType == typeof(Boat):
                    return "Boat";
                default:
                    return "Vehicle";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
