using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace VideoGameCollector.Converters
{
    public class StringToBackgroundImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imagename = value as string;

            Debug.Print(imagename);
            return new Uri(string.Format("https://images.igdb.com/igdb/image/upload/t_screenshot_huge/{0}.jpg", imagename));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
