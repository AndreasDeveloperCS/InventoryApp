using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace InventoryApp.Views.Converters
{
    public class ImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string imagePath && !string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    var uri = $"pack://application:,,,/Inventory.Core;component/InventoryItemPhotoCore/{imagePath}";
              
                    var bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = new Uri(uri, UriKind.RelativeOrAbsolute);
                    bitmapImage.EndInit();
                    return bitmapImage;
                   
                }
                catch(Exception ex)
                {
                    //ToDo:Logging
                    return null;
                }
                
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
           return value;
        }
    }
}
