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

        public Game Game
        {
            get { return game; }
            set
            {
                game = value;
                OnPropertyChanged("Game");
            }
        }

        public GameDetalsViewModel()
        {
            Messenger.Default.Register<Game>(this, NotifyMe);
        }

        public void NotifyMe(Game sentGame)
        {
            Game = sentGame;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
