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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test", "Test", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.Source as Button)?.Content.ToString());
        }

        private void Grid_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }
    }
}