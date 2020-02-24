using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace VideoGameCollector.Converters
{
    public class StringToImageConverter : IValueConverter
    {
        // Returns a formatted uri for displaying covers

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                string imagename = value as string;
                return new Uri(string.Format("https://images.igdb.com/igdb/image/upload/t_cover_big/{0}.jpg", imagename));
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
