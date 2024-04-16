using System;
using System.Globalization;
using System.Windows.Data;

namespace Inventory.UI.Core.Converters
{
    public class EnumToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !value.GetType().IsEnum)
                return null;

            return GetEnumDescription((Enum)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        private string GetEnumDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = (System.ComponentModel.DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
