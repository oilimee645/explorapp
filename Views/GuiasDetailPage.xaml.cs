using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExplorAppTeo.Models;
using ExplorAppTeo.ViewModels;
using ExplorAppTeo.Services;

namespace ExplorAppTeo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GuiasDetailPage : ContentPage
    {
        GuiasDetailViewModel lugarviewmodel;

        public GuiasDetailPage()
        {
            InitializeComponent();
        }

        public GuiasDetailPage(GuiasDetailViewModel lugarviewmodel)
        {
            InitializeComponent();

            BindingContext = this.lugarviewmodel = lugarviewmodel;
            this.Title = lugarviewmodel.Lugar.Nombre;
        }
    }
}