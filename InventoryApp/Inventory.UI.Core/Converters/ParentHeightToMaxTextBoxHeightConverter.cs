using System;
using System.Globalization;

namespace Inventory.UI.Core.Converters
{
    internal class ParentHeightToMaxTextBoxHeightConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
          
            if (value is double parentHeight && parentHeight > 0)
            {
                return parentHeight * 0.9;
            }
            return double.NaN;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
