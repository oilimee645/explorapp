using System;
using System.Windows.Input;

using ExplorAppTeo.Models;
using Xamarin.Forms;

namespace ExplorAppTeo.ViewModels
{
    public class RestaurantesDetailViewModel : BaseViewModel
    {
        public LugarItem Lugar { get; set; }

        public RestaurantesDetailViewModel()
        {
            Title = "Restaurante";
        }

        public RestaurantesDetailViewModel(LugarItem lugarItem = null)
        {
            Title = "Restaurante";
            Title = lugarItem?.Nombre;
            Lugar = lugarItem;
        }

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
