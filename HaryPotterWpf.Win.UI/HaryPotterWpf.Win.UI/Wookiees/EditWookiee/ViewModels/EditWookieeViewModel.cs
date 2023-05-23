using HaryPotterWpf.Win.UI.Core;
using HaryPotterWpf.Win.UI.Core.Commands;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HaryPotterWpf.Win.UI.Wookiees.EditWookiee.ViewModels
{
    public class EditWookieeViewModel : BaseBindable
    {
        public EditWookieeViewModel()
        {
            this.Save = new RelayCommand(this.OnSave);
            this.Cancel = new RelayCommand(this.OnCancel);
        }

        private void OnCancel(object? sender, EventArgs e)
        {

        }

        private void OnSave(object? sender, EventArgs e)
        {

        }

        public ICommand Cancel { get; init; }

        public ICommand Save { get; init; }

        private string label = string.Empty;

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public string Label
        {
            get => this.label;
            set
            {
                this.label = value;

                if(string.IsNullOrEmpty(this.label))
                {
                    // throw new Exception("Empty field");
                }

                this.OnPropertyChanged(() => this.Label);
            }
        }

        public bool HasErrors => throw new NotImplementedException();
    }
}
