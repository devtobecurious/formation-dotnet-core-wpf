using HaryPotterWpf.Win.UI.Wookiees.ListWookiees.Services;
using HaryPotterWpf.Win.UI.Wookiees.ListWookiees.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HaryPotterWpf.Win.UI.Wookiees.ListWookiees
{
    /// <summary>
    /// Logique d'interaction pour ListWookies.xaml
    /// </summary>
    public partial class ListWookies : Window
    {
        public ListWookies()
        {
            InitializeComponent();

            ListWookieesWindowService service = new();
            ListWookieesViewModel viewModel = new()
            {
                WindowService = service
            };

            this.DataContext = viewModel;
        }
    }
}
