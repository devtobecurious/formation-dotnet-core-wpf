using HaryPotterWpf.Win.UI.Core;
using HaryPotterWpf.Win.UI.Core.Commands;
using HaryPotterWpf.Win.UI.Core.Services;
using HaryPotterWpf.Win.UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HaryPotterWpf.Win.UI.Wookiees.ListWookiees.ViewModels
{
    public class ListWookieesViewModel : BaseBindable
    {
        public ListWookieesViewModel()
        {
            this.AddNewWookie = new RelayCommand(this.OnAddNewWookie);
            this.EditNewWookie = new RelayCommand(this.OnEditNewWookie);
        }

        private void OnAddNewWookie(object? sender, EventArgs e)
        {
            this.Wookiees.Add(new() { Label = "Coucou" });
        }

        private void OnEditNewWookie(object? sender, EventArgs e)
        {
            if(this.WindowService != null)
            {
                this.WindowService.Show(this);
            }
        }

        public ObservableCollection<Wookiee> Wookiees { get; set; } = new();

        public IWindowService? WindowService { get; set; }

        public ICommand AddNewWookie { get; init; }
        public ICommand EditNewWookie { get; init; }
    }
}
