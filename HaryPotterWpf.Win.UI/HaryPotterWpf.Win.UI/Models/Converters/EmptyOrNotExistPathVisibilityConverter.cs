using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace HaryPotterWpf.Win.UI.Models.Converters
{
    public class EmptyOrNotExistPathVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var visibility = Visibility.Visible;
            var path = value as string;

            if(string.IsNullOrEmpty(path))
            {
                return Visibility.Hidden;
            }

            path = Path.Combine(Environment.CurrentDirectory, "Images", path);
            if (! File.Exists(path))
            {
                visibility = Visibility.Hidden;
            }

            return visibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
