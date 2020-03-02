using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExplorAppTeo.Models;
using ExplorAppTeo.ViewModels;
using ExplorAppTeo.Services;

namespace ExplorAppTeo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventosDetailPage : ContentPage
    {
        EventosDetailViewModel lugarviewmodel;

        public EventosDetailPage()
        {
            InitializeComponent();
        }

        public EventosDetailPage(EventosDetailViewModel lugarviewmodel)
        {
            InitializeComponent();

            BindingContext = this.lugarviewmodel = lugarviewmodel;
            this.Title = lugarviewmodel.Lugar.Nombre;
        }
    }
}