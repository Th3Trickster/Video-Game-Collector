using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using VideoGameCollector.Models;

namespace VideoGameCollector.ViewModels
{
    public class GameDetalsViewModel : INotifyPropertyChanged
    {
        private Game game;
        private Screenshot selectedScreenshot;
        private Game selectedDlc;

        public RelayCommand ShowScreenshotPopupWindowViewCommand { private set; get; }
        public RelayCommand ShowDlcPopupCommand { private set; get; }

        public Game Game
        {
            get { return game; }
            set
            {
                game = value;
                OnPropertyChanged("Game");
            }
        }

        public Game SelectedDlc
        {
            get { return selectedDlc; }
            set
            {
                selectedDlc = value;
                OnPropertyChanged("SelectedDlc");
                Messenger.Default.Send(SelectedDlc);
            }
        }

        public Screenshot SelectedScreenshot
        {
            get { return selectedScreenshot; }
            set
            {
                selectedScreenshot = value;
                OnPropertyChanged("SelectedScreenshot");
                ShowScreenshotPopupWindowViewCommandExecute();
                Messenger.Default.Send(SelectedScreenshot);
            }
        }

        public GameDetalsViewModel()
        {
            Messenger.Default.Register<Game>(this, NotifyMe);
            ShowScreenshotPopupWindowViewCommand = new RelayCommand(ShowScreenshotPopupWindowViewCommandExecute);
            ShowDlcPopupCommand = new RelayCommand(ShowDlcPopupCommandExecute);
        }

        public void NotifyMe(Game sentGame)
        {
            Game = sentGame;
        }

        public void ShowScreenshotPopupWindowViewCommandExecute()
        {
            Messenger.Default.Send(new NotificationMessage("ShowScreenshotPopupWindow"));
        }

        public void ShowDlcPopupCommandExecute()
        {
            Messenger.Default.Send(new NotificationMessage("ShowDlcPopup"));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
