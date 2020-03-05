using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using VideoGameCollector.Helpers;
using VideoGameCollector.Models;
using VideoGameCollector.ViewModels.Commands;

namespace VideoGameCollector.ViewModels
{
    public class BrowseGamesViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private string query;
        private Game selectedGame;
        private int gamesCount;
        private Game game;

        public RelayCommand ShowGameDetailsViewCommand { private set; get; }
        public string Query
        {
            get { return query; }
            set
            {
                query = value;
                OnPropertyChanged("Query");
            }
        }
        public Game Game
        {
            get { return game; }
            set
            {
                game = value;
                OnPropertyChanged("Game");
            }
        }

        public Game SelectedGame
        {
            get { return selectedGame; }
            set
            {
                selectedGame = value;
                OnPropertyChanged("SelectedGame");
                GetGameDetails();
                ShowGameDetailsViewCommandExecute();
            }
        }

        public ObservableCollection<Game> Games { get; set; }
        public int GamesCount
        {
            get { return gamesCount; }
            set
            {
                gamesCount = value;
                OnPropertyChanged("GamesCount");
            }
        }
        public SearchGamesCommand SearchGamesCommand { get; set; }

        public BrowseGamesViewModel()
        {
            Games = new ObservableCollection<Game>();
            SearchGamesCommand = new SearchGamesCommand(this);
            ShowGameDetailsViewCommand = new RelayCommand(ShowGameDetailsViewCommandExecute);
        }

        public async void MakeQuery()
        {
            var games = await IGDBHelper.GetGames(Query);

            Games.Clear();
            foreach (var game in games)
            {
                Games.Add(game);
            }

            // For the Games Shown label.
            GamesCount = Games.Count;
        }

        public void ShowGameDetailsViewCommandExecute()
        {
            Messenger.Default.Send(new NotificationMessage("ShowGameDetailsView"));
        }

        private async void GetGameDetails()
        {
            Game = await IGDBHelper.GetGameInformation(SelectedGame.id);
            Messenger.Default.Send(Game);
            // Clear the listbox by clearing it in the search command button
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
