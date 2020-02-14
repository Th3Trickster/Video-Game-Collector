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

        public static readonly DependencyProperty HeaderTextProperty =
            DependencyProperty.Register("HeaderText", typeof(string), typeof(ListBoxWithImage), new PropertyMetadata(0));

        public ListBoxWithImage()
        {
            InitializeComponent();
        }
    }
}
