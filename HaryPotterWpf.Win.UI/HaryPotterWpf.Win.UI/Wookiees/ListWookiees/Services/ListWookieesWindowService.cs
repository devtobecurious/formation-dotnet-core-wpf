using HaryPotterWpf.Win.UI.Core;
using HaryPotterWpf.Win.UI.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaryPotterWpf.Win.UI.Wookiees.ListWookiees.Services
{
    public class ListWookieesWindowService : IWindowService
    {
        public void Show(BaseBindable viewModel)
        {
            (new EditWookiee.EditWookiee()).Show();
        }
    }
}
