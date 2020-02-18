using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VideoGameCollector.UserControls
{
    /// <summary>
    /// Interaction logic for ListBoxWithImage.xaml
    /// </summary>
    public partial class ListBoxWithImage : UserControl
    {
        public string HeaderText
        {
            get { return (string)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }

        public string DeveloperName
        {
            get { return (string)GetValue(DeveloperNameProperty); }
            set { SetValue(DeveloperNameProperty, value); }
        }

        public string CoverArt
        {
            get { return (string)GetValue(CoverArtProperty); }
            set { SetValue(CoverArtProperty, value); }
        }

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(ListBoxWithImage));

        public static readonly DependencyProperty CoverArtProperty =
            DependencyProperty.Register("CovertArt", typeof(string), typeof(ListBoxWithImage));

        public static readonly DependencyProperty DeveloperNameProperty =
            DependencyProperty.Register("DeveloperName", typeof(string), typeof(ListBoxWithImage));

        public static readonly DependencyProperty HeaderTextProperty =
            DependencyProperty.Register("HeaderText", typeof(string), typeof(ListBoxWithImage));

        public ListBoxWithImage()
        {
            InitializeComponent();
        }
    }
}
