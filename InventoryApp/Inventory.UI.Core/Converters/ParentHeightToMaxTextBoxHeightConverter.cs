using System;
using System.Globalization;
using System.Windows.Data;

namespace Inventory.UI.Core.Converters
{
    internal class ParentHeightToMaxTextBoxHeightConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double coefficientConversion = (parameter is double) ? (double)parameter : 1;
            if (value is double parentHeight && parentHeight > 0)
            {
                return parentHeight * coefficientConversion;
            }
            return double.NaN;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
