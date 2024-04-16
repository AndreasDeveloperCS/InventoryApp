using Inventory.Core.InventoryModels;
using System;
using System.Globalization;
using System.Windows.Data;

namespace InventoryApp.Views.Converters
{
    public class WheelsNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.GetType())
            {
                case Type vehicleType when vehicleType == typeof(Car):
                    return ((Car)value).NumberOfWheels;
                case Type vehicleType when vehicleType == typeof(Aeroplane):
                    return ((Aeroplane)value).WheelCount;
                case Type vehicleType when vehicleType == typeof(Boat):
                    return "";
                default:
                    return "";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
