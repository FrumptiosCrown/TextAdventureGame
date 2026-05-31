using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using TextAdventureGame.Sources.UI.Views;

namespace TextAdventureGame.Sources.UI.ViewModels
{
    internal partial class MainMenuViewModel 
    {
        public ICommand myCommand { get; }
        public MainMenuViewModel() 
        {
            myCommand = new RelayCommand(OnButton, _ => true);
        }
        public void OnButton(object? obj)
        {
            if (obj is null)
                return;
            switch(obj.ToString())
            {
                case "Start":
                    GameWindow gameWindow = new();
                    gameWindow.Show();
                    break;
                case "Settings":
                    SettingWindow settingWindow = new();
                    settingWindow.Show();
                    break;
                case "Quit":
                    Application.Current.Shutdown();
                    break;
            }
        }
    }
}
