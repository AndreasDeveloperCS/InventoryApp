using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Inventory.UI.Core.Converters
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (null == value)
            {
                return null;
            }
            // For a more sophisticated converter, check also the targetType and react accordingly..
            if (value is Color)
            {
                var color = (Color)value;
                return new SolidColorBrush(color);
            }
         
            Type type = value.GetType();
            throw new InvalidOperationException("Unsupported type [" + type.Name + "]");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
