using System.ComponentModel;
using System.Windows.Input;
using TextAdventureGame.Sources.AI;

namespace TextAdventureGame.Sources.UI.ViewModels
{
    internal class GameWindowViewModel : INotifyPropertyChanged
    {
        public ICommand GameWindowCommand { get; }
        public Narrator narrator = new();

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
            GameWindowCommand = new RelayCommand(obj => OnClick(obj as string), CanClick);
        }
        public async void OnClick(string? obj)
        {
            if (obj is null)
                return;
           AIOutput = await narrator.SendActionToAI(obj);
        }
        public bool CanClick(object? obj) => obj is not null;
    }
}
