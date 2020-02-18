﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using VideoGameCollector.Helpers;
using VideoGameCollector.Models;
using VideoGameCollector.ViewModels.Commands;

namespace VideoGameCollector.ViewModels
{
    public class BrowseGamesViewModel : INotifyPropertyChanged
    {
        private string query;
        private string selectedGame;
        private int gamesCount;

        public string Query
        {
            get { return query; }
            set
            {
                query = value;
                OnPropertyChanged("Query");
            }
        }

        public string SelectedGame
        {
            get { return selectedGame; }
            set
            {
                selectedGame = value;
                OnPropertyChanged("SelectedGame");
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
