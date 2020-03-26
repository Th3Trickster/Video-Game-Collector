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
    public class ScreenshotPopupWindowViewModel : INotifyPropertyChanged
    {
        private Screenshot screenshot;

        public Screenshot Screenshot
        {
            get { return screenshot; }
            set
            {
                screenshot = value;
                OnPropertyChanged("Screenshot");
            }
        }

        public ScreenshotPopupWindowViewModel()
        {
            Messenger.Default.Register<Screenshot>(this, RecieveMessage);
        }

        public void RecieveMessage(Screenshot sentScreenshot)
        {
            Screenshot = sentScreenshot;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
