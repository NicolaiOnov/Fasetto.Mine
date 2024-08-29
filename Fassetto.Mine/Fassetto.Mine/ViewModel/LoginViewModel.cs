using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Fassetto.Mine.ViewModel.Base;

namespace Fassetto.Mine.ViewModel
{
    public class LoginViewModel: BaseViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayParameterizedCommand(async (arg) => { await Login(arg);});
        }

        public async Task Login(object arg)
        {
            throw new NotImplementedException();
        }
    }
}
