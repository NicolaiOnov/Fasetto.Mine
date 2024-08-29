using System;
using System.Windows.Input;

namespace Fassetto.Mine.ViewModel.Base
{
    internal class RelayParameterizedCommand: ICommand
    {
        private readonly Action<object> _action;

        public RelayParameterizedCommand(Action<object> action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }

        public event EventHandler CanExecuteChanged = (sender, e) => {};
    }
}
