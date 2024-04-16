using System;
using System.Globalization;
using System.Windows.Data;

namespace Inventory.UI.Core.Converters
{
    internal class ParentSizeToMaxSizeSubstructConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           
            if (value is double parentElementSize && parentElementSize > 0)
            {
                double coefficientSubstruct = (parameter is double) ? (double)parameter : parentElementSize / 2;
                return parentElementSize - coefficientSubstruct;
            }
            return double.NaN;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
