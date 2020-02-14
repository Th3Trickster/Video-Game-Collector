using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace VideoGameCollector.ViewModels.Commands
{
    public class SearchGamesCommand : ICommand
    {
        public BrowseGamesViewModel BrowseGamesViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public SearchGamesCommand(BrowseGamesViewModel vm)
        {
            BrowseGamesViewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            BrowseGamesViewModel.MakeQuery();
        }
    }
}
