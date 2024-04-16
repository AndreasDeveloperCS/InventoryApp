using System;
using System.Globalization;
using System.Windows.Data;

namespace InventoryApp.Views.Converters
{
    public class EnvironmentTypeConverter :IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
