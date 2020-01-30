using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using MaterialDesignThemes;
using MaterialDesignColors;
using System.Collections;

namespace VideoGameCollector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // List of all buttons within the MainWindow. Used for changing
        // the style of the default button and checking if there is more 
        // than one default button selected.
        List<Button> buttons;
        List<Button> previousButtons;
        Button defaultButton;

        public MainWindow()
        {
            InitializeComponent();
            buttons = GetLogicalChildCollection<Button>(LeftNavBar);
            previousButtons = new List<Button>();
            SetDefaultButtonStyle();
        }

        private void ChangeCurrentSelectedButton(object sender, RoutedEventArgs e)
        {
            // This method will change the active style based on the button selected.
            // It relies on storing the default button in the previousButtons list, this
            // button is added to the list in the SetDefaultButtonStyle Method.
            // The loop will loop through the previousButtons list and first
            // grab the the currentSelectedButtons Name from the click and the compare
            // it if it's not equal to to the previousButtons Name, since the defaultButton
            // is added at the start of the list it will look and see they do not match on
            // the first click, thus allowing the button to be changed.
            Button currentSelectedButton = (sender as Button);
            previousButtons.Add(currentSelectedButton);

            for (int i = 0; i < previousButtons.Count; i++)
            {
                if (currentSelectedButton.Name != previousButtons[i].Name)
                {
                    currentSelectedButton.Style = (Style)FindResource("MaterialDesignRaisedButton");
                    previousButtons[i].Style = (Style)FindResource("MaterialDesignFlatButton");
                }
            }
        }

        private void SetDefaultButtonStyle()
        {
            // Grabs the returned list from CheckIfMoreThanOneButtonIsDefault method
            // and applies the style to the default button.
            List<Button> button = CheckIfMoreThanOneButtonIsDefault();

            button[0].Style = (Style)FindResource("MaterialDesignRaisedButton");
            defaultButton = button[0];

            // Add default button to previousButtons list for changing style
            previousButtons.Add(defaultButton);
        }

        private List<Button> CheckIfMoreThanOneButtonIsDefault()
        {
            List<Button> numberOfDefaultButtons = new List<Button>();
           
            // Loops through the buttons and adds the one(s) that are set to default.
            // The list is returned only if 1 button is in list so that the new style can 
            // be applied.
            foreach(Button button in buttons)
            {
                if (button.IsDefault == true)
                {
                    numberOfDefaultButtons.Add(button);
                }
            }

            int numberOfDefaultButtonsCount = numberOfDefaultButtons.Count;

            if (numberOfDefaultButtonsCount > 1)
            {
                Debug.Print("Can't have more than one Default Button.");
            }
            else if (numberOfDefaultButtonsCount == 0)
            {
                Debug.Print("No Default Button found.");
            }

            return numberOfDefaultButtons;
        }

        public static List<T> GetLogicalChildCollection<T>(object parent) where T : DependencyObject
        {
            List<T> logicalCollection = new List<T>();
            GetLogicalChildCollection(parent as DependencyObject, logicalCollection);
            return logicalCollection;
        }

        private static void GetLogicalChildCollection<T>(DependencyObject parent, List<T> logicalCollection) where T : DependencyObject
        {
            IEnumerable children = LogicalTreeHelper.GetChildren(parent);
            foreach (object child in children)
            {
                if (child is DependencyObject)
                {
                    DependencyObject depChild = child as DependencyObject;
                    if (child is T)
                    {
                        logicalCollection.Add(child as T);
                    }
                    GetLogicalChildCollection(depChild, logicalCollection);
                }
            }
        }
    }
}