using GalaSoft.MvvmLight.Messaging;
using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;
using VideoGameCollector.UIHelpers;

namespace VideoGameCollector
{
    /// <summary>
    /// Interaction logic for GameDetailsView.xaml
    /// </summary>
    public partial class GameDetailsView : Window
    {
        ScreenshotPopupWindowView view;
        DlcPopupWindowView dlcView;

        public GameDetailsView()
        {
            InitializeComponent();
            Messenger.Default.Register<NotificationMessage>(this, NotificationMessageReceived);
            Messenger.Default.Register<NotificationMessage>(this, ShowDlcNotificationMessageReceived);
        }

        private void NotificationMessageReceived(NotificationMessage msg)
        {
            if (msg.Notification == "ShowScreenshotPopupWindow")
            {
                if (!WindowOpenHelper.IsWindowOpen<ScreenshotPopupWindowView>())
                {
                    view = new ScreenshotPopupWindowView();
                    view.Show();
                }
                else
                {
                    view.Activate();
                }
            }
        }

        private void ShowDlcNotificationMessageReceived(NotificationMessage msg)
        {
            if (msg.Notification == "ShowDlcPopup")
            {
                if (!WindowOpenHelper.IsWindowOpen<DlcPopupWindowView>())
                {
                    dlcView = new DlcPopupWindowView();
                    dlcView.Show();
                }
                else
                {
                    dlcView.Activate();
                }
            }
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
