using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Inventory.UI.Core.Converters
{
    public class BooleanToVisibilityConverter :IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool flag = value is null ? false : true;
            if (value is bool)
            {
                var nullable = value as bool?;
                flag = nullable.Value;
            }

            return (flag ? Visibility.Visible : (parameter ?? Visibility.Collapsed));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
