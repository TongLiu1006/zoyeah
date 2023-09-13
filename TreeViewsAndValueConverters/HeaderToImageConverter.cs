using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace TreeViewsAndValueConverters
{
    /// <summary>
    /// converts  a full path to a specifics image type of a drive,folder or file
    /// </summary>
    [ValueConversion(typeof(string),typeof(BitmapImage))]
    public   class HeaderToImageConverter : IValueConverter
    {

        public static HeaderToImageConverter Instance = new HeaderToImageConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           return new object();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
