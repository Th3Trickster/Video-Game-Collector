﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VideoGameCollector.UIHelpers
{
    public class WindowOpenHelper
    {
        public static bool IsWindowOpen<T>(string name = "") where T : Window
        {
            return string.IsNullOrEmpty(name)
                ? Application.Current.Windows.OfType<T>().Any()
                : Application.Current.Windows.OfType<T>().Any(w => w.Name.Equals(name));
        }
    }
}
