using System;
using System.Globalization;
using System.Windows.Data;

namespace Inventory.UI.Core.Converters
{
    internal class ParentSizeToMaxControlSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double coefficientConversion = (parameter is double) ? (double)parameter : 1;
            if (value is double parentElementSize && parentElementSize > 0)
            {
                return parentElementSize * coefficientConversion;
            }
            return double.NaN;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
