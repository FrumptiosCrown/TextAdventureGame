using System.ComponentModel;
using System.Threading.Channels;
using System.Windows;
using System.Windows.Input;
using TextAdventureGame.Sources.AI;
using TextAdventureGame.Sources.Manager;
using TextAdventureGame.Sources.UI.Views;

namespace TextAdventureGame.Sources.UI.ViewModels
{
    internal class GameWindowViewModel : INotifyPropertyChanged
    {
        public ICommand textboxCommand { get; }
        public ICommand buttonCommand { get; }
        public ICommand closeWindowCommand { get; }
        public Narrator narrator = new();
        public GameManager gameManager = new();
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _aIOutput;
        public string AIOutput
        {
            get => _aIOutput;
            set
            {
                if (_aIOutput == value)
                    return;
                _aIOutput = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AIOutput)));
            }
        }
        public GameWindowViewModel()
        {
            textboxCommand = new RelayCommand(obj => OnTextAction(obj as string), CanTextAction);
            buttonCommand = new RelayCommand(obj => OnButton(obj as string), _ => true);
            closeWindowCommand = new RelayCommand(obj => OnClose(obj), _ => true);
        }
        public async void OnTextAction(string? obj)
        {
            if (obj is null)
                return;
           AIOutput = await narrator.SendActionToAI(obj);
        }
        public void OnButton(object? obj)
        {
            switch (obj)
            {
                case "player":
                    PlayerWindow playerWindow = new(gameManager);
                    playerWindow.Show();
                    break;
                case "quit" when obj is Window:
                    Window window = (Window)obj;
                    window.Close();
                    break;
            }
        }
        public void OnClose(object? obj)
        {
            if (obj is null || (Window)obj is null)
                return;
            Window window = (Window)obj;
            window.Close();
        }
        public bool CanTextAction(object? obj) => obj is not null;

    }
}
