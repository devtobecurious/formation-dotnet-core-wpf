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

        private string avatar = string.Empty;
        public string Avatar
        {
            get => avatar;
            set
            {
                avatar = value;
                this.PropertyChanged?.Invoke(this, new(nameof (Avatar)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
