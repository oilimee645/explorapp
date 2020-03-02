 using System;
using System.ComponentModel;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExplorAppTeo.Models;
using ExplorAppTeo.ViewModels;
using ExplorAppTeo.Services;

namespace ExplorAppTeo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class EventosPage : ContentPage
    {
        public EventosPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            LugaresListView.ItemsSource = await App.Database.GetCatalogoLugarItems("Eventos");
        }

        private async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            LugarItem item = e.SelectedItem as LugarItem;

            if (item == null)
            {
                return;
            }

            await Navigation.PushAsync(new EventosDetailPage(new EventosDetailViewModel(item)));

            LugaresListView.SelectedItem = null;
        }
    }
}