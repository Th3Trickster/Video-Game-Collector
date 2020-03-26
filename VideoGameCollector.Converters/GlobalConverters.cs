using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
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

    public class NullRatingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Returns an empty string if the value is 0, this will remove
            // any games that have no rating and prevent the games from displaying
            // 0.
            double result = System.Convert.ToDouble(value);
            if (result == 0)
            {
                return "";
            }
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class UnixTimestampToDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int timeStamp = System.Convert.ToInt32(value);

            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(timeStamp);

            return dtDateTime.ToString("MMM d, yyyy");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
