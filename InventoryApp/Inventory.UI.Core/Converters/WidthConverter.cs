using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Inventory.UI.Core.Converters
{
    public class WidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double width = 50;
            if (value is double)
            {
                double columnWidth = System.Convert.ToDouble(value);
                width = columnWidth > 25.0  ? columnWidth - 25.0 : columnWidth;
            }
            
            return width;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
