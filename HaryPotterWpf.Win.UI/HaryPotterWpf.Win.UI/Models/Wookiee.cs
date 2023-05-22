using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaryPotterWpf.Win.UI.Models
{
    public class Wookiee : INotifyPropertyChanged
    {
        private string label = "";

        public string Label
        {
            get => this.label;
            set
            {
                this.label = value;
                this.PropertyChanged?.Invoke(this, new(nameof(Label)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
