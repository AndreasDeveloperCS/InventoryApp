using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Inventory.UI.Core.Converters
{
    class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Bitmap bitmap = null;
            if (value is Bitmap)
            {
                bitmap = value as Bitmap;
            }
            else
            {
                return value;
            }
            try
            {
               using(var memory = new MemoryStream())
               {
                   bitmap.Save(memory, ImageFormat.Jpeg);

                   var bitmapImage = new BitmapImage();
                   bitmapImage.BeginInit();
                   bitmapImage.DecodePixelWidth = 300;
                   bitmapImage.DecodePixelHeight = 120;
                   bitmapImage.StreamSource = memory;
                   bitmapImage.EndInit();
                   bitmapImage.Freeze();

                   return bitmapImage;
              }
            }
            catch (Exception ex)
            {
                //ToDo: Logging
                MessageBox.Show(ex.Message);

                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteObject([In] IntPtr hObject);

        public static ImageSource ImageSourceFromBitmap(Bitmap bmp)
        {
            IntPtr handle = bmp.GetHbitmap();

            try
            {
                return Imaging.CreateBitmapSourceFromHBitmap(handle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromWidthAndHeight(bmp.Height, bmp.Width));
            }
            finally { DeleteObject(handle); }
        }
    }
}
