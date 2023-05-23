using HaryPotterWpf.Win.UI.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace HaryPotterWpf.Win.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public Wookiee Wookiee { get; set; } = new() {  Label = "Chewie" };

        public ObservableCollection<Wookiee> Wookiees { get; set; } = new();

        private BackgroundWorker worker = new();

        public event PropertyChangedEventHandler? PropertyChanged;

        private int nbWookies = 1;
        public int NbWookies
        {
            get => nbWookies;
            set
            {
                this.nbWookies = value;
                this.PropertyChanged?.Invoke(this, new(nameof(nbWookies)));

                this.InitListWookiees();
            }
        }

        private int index = 0;
        public int Index
        {
            get => index;
            set
            {
                index = value;
                this.PropertyChanged?.Invoke(this, new(nameof(Index)));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            //this.btnOneWookie.DataContext = this.Wookiee;

            this.worker.DoWork += Worker_DoWork;
        }

        private void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            this.SlowMethod(1000);
        }

        private void btnName_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test", "Test", MessageBoxButton.OK, MessageBoxImage.Error);
            this.grdInputs.Visibility = Visibility.Visible;
            this.grdSteps.Visibility = Visibility.Visible;

            //var resource = this.Resources["buttonColorBackground"] as Style;
            //var setter = resource?.Setters.Where(item => ((Setter)item).Property.Name == "Background").First() as Setter;

            //setter.Value = Colors.DarkGreen;

           this.Resources["backgroundColor"] = new SolidColorBrush(Colors.DarkGreen);

        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.Source as Button)?.Content.ToString());
        }

        private void Grid_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var textBox = e.Source as TextBox;

            if (textBox != null && string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Un champs obligatoire est vide", "Requis", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void btnName2_Click(object sender, RoutedEventArgs e)
        {
            this.Wookiee.Label = "Kashyyk";
        }

        private void btnName3_Click(object sender, RoutedEventArgs e)
        {
            this.SlowMethod(1000);
        }

        private void SlowMethod(int nbIteration = 10000)
        {
            for (int i = 0; i < nbIteration; i++)
            {
                this.Index = i;
                Thread.Sleep(100);
            }
        }

        private void btnName4_Click(object sender, RoutedEventArgs e)
        {
            this.worker.RunWorkerAsync();
        }

        private void InitListWookiees()
        {
            this.Wookiees.Clear();
            for (int i = 0; i < this.NbWookies; i++)
            {
                this.Wookiees.Add(new()
                {
                    Label = $"Wookie{i}"
                });
            }
        }
    }
}