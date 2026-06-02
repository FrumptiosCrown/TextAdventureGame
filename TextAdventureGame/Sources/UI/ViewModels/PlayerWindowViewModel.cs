using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using TextAdventureGame.Sources.Manager;

namespace TextAdventureGame.Sources.UI.ViewModels
{
    internal class PlayerWindowViewModel : INotifyPropertyChanged
    {
        ICommand playerCommand;
        GameManager gameManager;
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _stats; 
        public string stats
        {
            get => _stats;
            set
            {
                if (_stats == value)
                    return;
                _stats = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(stats)));
            }
        }
        public PlayerWindowViewModel() 
        {
            playerCommand = new RelayCommand(onAction, canExecute);
        }
        public PlayerWindowViewModel(GameManager gameManagerparam)
        {
            playerCommand = new RelayCommand(onAction, canExecute);
            gameManager = gameManagerparam;
            UpdateStats();
        }
        private void UpdateStats()
        {
            stats = gameManager.getStats(); 
        }
        private void onAction(object? obj)
        {

        }
        private bool canExecute(object? obj) => true;
    }
}
