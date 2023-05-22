using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace HaryPotterWpf.Win.UI.Models.Converters
{
    public class PathToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string path = (string)value;

            if (! string.IsNullOrEmpty(path))
            {
                path = Path.Combine(Environment.CurrentDirectory, "Images", path);

                var image = new BitmapImage();

                using var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                image.BeginInit();

                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = stream;

                image.EndInit();

                return image;
            }

            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
