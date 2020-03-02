using System;
using System.Windows.Input;

using ExplorAppTeo.Models;
using Xamarin.Forms;

namespace ExplorAppTeo.ViewModels
{
    public class BaresDetailViewModel : BaseViewModel
    {
        public LugarItem Lugar { get; set; }

        public BaresDetailViewModel()
        {
            Title = "Bar";
        }

        public BaresDetailViewModel(LugarItem lugarItem = null)
        {
            Title = "Bar";
            Title = lugarItem?.Nombre;
            Lugar = lugarItem;
        }

        [Obsolete]
        public ICommand WebCommand => new Command<string>((url) =>
        {
            Uri webUri;

            bool result = Uri.TryCreate(url, UriKind.Absolute, out webUri) && (webUri.Scheme == Uri.UriSchemeHttp || webUri.Scheme == Uri.UriSchemeHttps);

            if (result)
            {
                Device.OpenUri(webUri);
            }
        });
    }
}
