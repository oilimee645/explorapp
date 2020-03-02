using ExplorAppTeo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExplorAppTeo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class PuertasPage : ContentPage
    {
        List<PuertasMenuItem> menuItems;
        
        public PuertasPage()
        {
            InitializeComponent();

            menuItems = new List<PuertasMenuItem>
            {
                new PuertasMenuItem { Id = PuertasItemType.Puerta1, Title = "Puerta 1" },
                new PuertasMenuItem { Id = PuertasItemType.Puerta2, Title = "Puerta 2" },
                new PuertasMenuItem { Id = PuertasItemType.Puerta3, Title = "Puerta 3" },
                new PuertasMenuItem { Id = PuertasItemType.Puerta4, Title = "Puerta 4" },
                new PuertasMenuItem { Id = PuertasItemType.Puerta5, Title = "Puerta 5" }
            };

            PuertasListView.ItemsSource = menuItems;
        }

        async void OnButtonClicked(object sender, EventArgs arg)
        {
            var button = (Button)sender;
           
            await Navigation.PushAsync(new GuiaPage(button.ClassId));
        }
    }
}