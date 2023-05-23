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
        private static Random random = new Random();

        private string label = "";

        public void Move()
        {
            var nextX = random.Next(-1, 2);
            var nextY = random.Next(-1, 2);

            this.Position = new(this.Position.X + nextX, this.Position.Y + nextY);
        }

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

        private Position position = new(1, 1);
        public Position Position
        {
            get => position;
            set
            {
                position = value;
                this.PropertyChanged?.Invoke(this, new(nameof(Position)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
