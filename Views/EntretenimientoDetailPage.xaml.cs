using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExplorAppTeo.Models;
using ExplorAppTeo.ViewModels;
using ExplorAppTeo.Services;

namespace ExplorAppTeo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntretenimientoDetailPage : ContentPage
    {
        EntretenimientoDetailViewModel lugarviewmodel;

        public EntretenimientoDetailPage()
        {
            InitializeComponent();
        }

        public EntretenimientoDetailPage(EntretenimientoDetailViewModel lugarviewmodel)
        {
            InitializeComponent();

            BindingContext = this.lugarviewmodel = lugarviewmodel;
            this.Title = lugarviewmodel.Lugar.Nombre;
        }
    }
}