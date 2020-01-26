using System;
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

namespace VideoGameCollector.User_Controls
{
    /// <summary>
    /// Interaction logic for MainWindowNavigationButton.xaml
    /// </summary>
    public partial class MainWindowNavigationButton : UserControl
    {
        public string ImagePath
        {
            get { return (string)GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }

        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public static readonly DependencyProperty ImagePathProperty =
            DependencyProperty.Register("ImagePath", typeof(string), typeof(MainWindowNavigationButton), new PropertyMetadata("No Image path provided. No image will be shown."));


        public static readonly DependencyProperty ButtonTextProperty =
            DependencyProperty.Register("ButtonText", typeof(string), typeof(MainWindowNavigationButton), new PropertyMetadata("No Button text provided. Button will have blank text"));


        public MainWindowNavigationButton()
        {
            InitializeComponent();
        }
    }
}
