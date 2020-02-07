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
    /// Interaction logic for Card.xaml
    /// </summary>
    public partial class Card : UserControl
    {
        public string CardImage
        {
            get { return (string)GetValue(CardImageProperty); }
            set { SetValue(CardImageProperty, value); }
        }

        public string CardHeader
        {
            get { return (string)GetValue(CardHeaderProperty); }
            set { SetValue(CardHeaderProperty, value); }
        }

        public string CardDescription
        {
            get { return (string)GetValue(CardDescriptionProperty); }
            set { SetValue(CardDescriptionProperty, value); }
        }

        public string CardLeadingTextIcon
        {
            get { return (string)GetValue(CardLeadingTextIconProperty); }
            set { SetValue(CardLeadingTextIconProperty, value); }
        }

        public string CardFooter
        {
            get { return (string)GetValue(CardFooterProperty); }
            set { SetValue(CardFooterProperty, value); }
        }

        public string CardButtonIcon
        {
            get { return (string)GetValue(CardButtonIconProperty); }
            set { SetValue(CardButtonIconProperty, value); }
        }

        public string CardImageBackground
        {
            get { return (string)GetValue(CardImageBackgroundProperty); }
            set { SetValue(CardImageBackgroundProperty, value); }
        }

        public Card()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty CardImageProperty =
            DependencyProperty.Register("CardImage", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardHeaderProperty =
            DependencyProperty.Register("CardHeader", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardDescriptionProperty =
            DependencyProperty.Register("CardDescription", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardLeadingTextIconProperty =
            DependencyProperty.Register("CardLeadingTextIcon", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardFooterProperty =
            DependencyProperty.Register("CardFooter", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardButtonIconProperty =
            DependencyProperty.Register("CardButtonIcon", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardImageBackgroundProperty =
            DependencyProperty.Register("CardImageBackground", typeof(string), typeof(Card));
    }
}