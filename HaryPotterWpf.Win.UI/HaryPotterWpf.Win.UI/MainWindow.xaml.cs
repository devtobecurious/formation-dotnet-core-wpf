using HaryPotterWpf.Win.UI.Models;
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
    public partial class MainWindow : Window
    {
        public Wookiee Wookiee { get; set; } = new() {  Label = "Chewier" };

        public MainWindow()
        {
            InitializeComponent();
            //this.btnOneWookie.DataContext = this.Wookiee;
        }

        private void btnName_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test", "Test", MessageBoxButton.OK, MessageBoxImage.Error);
            this.grdInputs.Visibility = Visibility.Hidden;
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
    }
}