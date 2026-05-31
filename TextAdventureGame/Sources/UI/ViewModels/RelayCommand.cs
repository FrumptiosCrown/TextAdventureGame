using System.Windows.Input;
using System.Windows.Media.Animation;

namespace TextAdventureGame.Sources.UI.ViewModels
{
    internal class RelayCommand : ICommand
    {
        public Action<object?> execute;
        public Func<object?, bool> canExecute;
        public event EventHandler? CanExecuteChanged;

        public RelayCommand(Action<object?> executeparamter, Func<object?,bool> canExecuteparamter = null)
        {
            execute = executeparamter; 
            canExecute = canExecuteparamter;
        }
        public bool CanExecute(object? parameter)
        {
            return canExecute == null || canExecute(parameter);
        }
        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}
