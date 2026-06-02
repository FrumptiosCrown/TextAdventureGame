using System.Windows;
using TextAdventureGame.Sources.Manager;
using TextAdventureGame.Sources.UI.ViewModels;

namespace TextAdventureGame.Sources.UI.Views
{
    /// <summary>
    /// Interaktionslogik für PlayerWindow.xaml
    /// </summary>
    public partial class PlayerWindow : Window
    {
        public PlayerWindow()
        {
            InitializeComponent();
            DataContext = new PlayerWindowViewModel();
        }
        public PlayerWindow(GameManager gameManager)
        {
            InitializeComponent();
            DataContext = new PlayerWindowViewModel(gameManager);
        }
    }
}
