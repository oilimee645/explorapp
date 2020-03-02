using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace ExplorAppTeo.ViewModels
{
    class AcercaViewModel : BaseViewModel
    {
        public AcercaViewModel()
        {
            Title = "Acerca";
            OpenWebCommand_Facebook = new Command(() => Device.OpenUri(new Uri("https://www.facebook.com/ExplorApp-Teotihuacan-985803631602618")));
        }

        public ICommand OpenWebCommand_Facebook { get; }
    }
}
