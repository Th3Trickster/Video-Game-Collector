using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace VideoGameCollector.Converters
{
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
}
