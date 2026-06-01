using System.Windows;
using TextAdventureGame.Sources.UI.ViewModels;
namespace TextAdventureGame.Sources.UI.Views
{
    /// <summary>
    /// Interaktionslogik für GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();
            DataContext = new GameWindowViewModel();
        }
    }
}
