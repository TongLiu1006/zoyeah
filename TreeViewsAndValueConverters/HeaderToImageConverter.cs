using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

            //get the full path
            var path=value as string;

            if (path == null)
                return null;

            //get the name of file/folder
            var name=MainWindow.GetFolderName(path);



            //by deafult,we presume an image
            var image = "Images/file.jpg";

            //if name is null,we presume it's a drive.
            if (string.IsNullOrEmpty(name) )image = "Images/drive.jpg";

            else if(new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory)) image= "Images/folder-open.jpg";

            var urlstring= new Uri($"pack://application:,,,/").ToString();

            var urll = new Uri($"pack://application:,,,../{image}");

            return new BitmapImage(urll);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
