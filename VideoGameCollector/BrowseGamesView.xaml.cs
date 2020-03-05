using GalaSoft.MvvmLight.Messaging;
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
using System.Windows.Shapes;
using VideoGameCollector.ViewModels;

namespace VideoGameCollector
{
    /// <summary>
    /// Interaction logic for BrowseGamesView.xaml
    /// </summary>
    public partial class BrowseGamesView : Window
    {
        public BrowseGamesView()
        {
            InitializeComponent();
            Messenger.Default.Register<NotificationMessage>(this, NotificationMessageReceived);
        }

        private void NotificationMessageReceived(NotificationMessage msg)
        {
            if (msg.Notification == "ShowGameDetailsView")
            {
                var view = new GameDetailsView();
                view.Show();
            }
        }
    }
}
