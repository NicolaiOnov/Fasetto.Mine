using Fassetto.Mine.Models;
using Fassetto.Mine.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fassetto.Mine.ViewModel
{
    internal class MainWindowViewModel : BaseViewModel
    {
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;
    }
}
