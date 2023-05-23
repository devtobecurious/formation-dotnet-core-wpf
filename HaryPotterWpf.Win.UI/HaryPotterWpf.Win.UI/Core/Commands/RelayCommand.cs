using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HaryPotterWpf.Win.UI.Core.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly EventHandler action;

        public RelayCommand(EventHandler action)
        {
            this.action = action;
        }

        public bool CanExecute(object? parameter)
        {
            return this.action != null;
        }

        public void Execute(object? parameter)
        {
            this.action?.Invoke(this, EventArgs.Empty);
        }
    }
}
