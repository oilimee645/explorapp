using System;
using System.Windows.Input;

using ExplorAppTeo.Models;
using Xamarin.Forms;

namespace ExplorAppTeo.ViewModels
{
    public class EventosDetailViewModel : BaseViewModel
    {
        public LugarItem Lugar { get; set; }

        public EventosDetailViewModel()
        {
            Title = "Evento";
        }

        public EventosDetailViewModel(LugarItem lugarItem = null)
        {
            Title = "Evento";
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
