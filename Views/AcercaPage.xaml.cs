using System;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ExplorAppTeo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AcercaPage : ContentPage
    {
        public AcercaPage()
        {
            InitializeComponent();
        }

        public void OnTappedImage(object sender, EventArgs args)
        {
            Device.OpenUri(new Uri("https://www.most.mx/"));
        }
    }
}