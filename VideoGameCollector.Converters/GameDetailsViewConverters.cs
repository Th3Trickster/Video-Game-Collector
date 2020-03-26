using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace VideoGameCollector.Converters
{
    public class VideoIdToYoutubeUrlConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                string videoId = value as string;
                return new Uri(String.Format("https://www.youtube.com/watch?v={0}", videoId));
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class StringToScreenshotConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                string imageName = value as string;
                return new Uri(string.Format("https://images.igdb.com/igdb/image/upload/t_screenshot_huge/{0}.jpg", imageName));
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class StringToBackgroundImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imagename = value as string;

            return new Uri(string.Format("https://images.igdb.com/igdb/image/upload/t_screenshot_huge/{0}.jpg", imagename));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class RegionIntegerToRegionString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int regionNumber = System.Convert.ToInt32(value);

            switch (regionNumber)
            {
                case 1:
                    return "Europe";

                case 2:
                    return "North America";

                case 3:
                    return "Australia";

                case 4:
                    return "New Zealand";

                case 5:
                    return "Japan";

                case 6:
                    return "China";

                case 7:
                    return "Asia";

                case 8:
                    return "Worldwide";

                default:
                    return "No Region Found";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class BoolAndZeroToCollapsedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                bool isFalse = System.Convert.ToBoolean(value);
                if (!isFalse)
                {
                    return "Collapsed";
                }
                else
                {
                    return "Visible";
                }
            }
            else if (value is int)
            {
                int valueZero = System.Convert.ToInt32(value);
                if (valueZero == 0)
                {
                    return "Collapsed";
                }
                else
                {
                    return "Visible";
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class GameWebsiteEnumToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int websiteEnum = System.Convert.ToInt32(value);

            switch (websiteEnum)
            {
                case 1:
                    return "Official Website";

                case 2:
                    return "Wikia";

                case 3:
                    return "Wikipedia";

                case 4:
                    return "Facebook";

                case 5:
                    return "Twitter";

                case 6:
                    return "Twitch";

                case 8:
                    return "Instagram";

                case 9:
                    return "Youtube";

                case 10:
                    return "iPhone";

                case 11:
                    return "iPad";

                case 12:
                    return "Android";

                case 13:
                    return "Steam";

                case 14:
                    return "Reddit";

                case 15:
                    return "Itch";

                case 16:
                    return "Epic Games";

                case 17:
                    return "GOG";

                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class IntegerToSocialMediaAndWebsiteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int number = System.Convert.ToInt32(value);
            string path = "/Assets/{0}.{1}";
            string imageExtension = "png";

            switch (number)
            {
                case 1:
                    return string.Format(path, "OfficialWebsite", imageExtension);

                case 2:
                    return string.Format(path, "Wikia", imageExtension);

                case 3:
                    return string.Format(path, "Wikipedia", imageExtension);

                case 4:
                    return string.Format(path, "Facebook", imageExtension);

                case 5:
                    return string.Format(path, "Twitter", imageExtension);

                case 6:
                    return string.Format(path, "Twitch", imageExtension);

                case 8:
                    return string.Format(path, "Instagram", imageExtension);

                case 9:
                    return string.Format(path, "Youtube", imageExtension);

                case 10:
                    return string.Format(path, "iPhone", imageExtension);

                case 11:
                    return string.Format(path, "iPad", imageExtension);

                case 12:
                    return string.Format(path, "Android", imageExtension);

                case 13:
                    return string.Format(path, "Steam", imageExtension);

                case 14:
                    return string.Format(path, "Reddit", imageExtension);

                case 15:
                    return string.Format(path, "Itch", imageExtension);

                case 16:
                    return string.Format(path, "Epic", imageExtension);

                case 17:
                    return string.Format(path, "Gog", imageExtension);
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
