using PropertyChanged;
using System.ComponentModel;

namespace Fassetto.Mine.ViewModel.Base
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => {};
    }
}
