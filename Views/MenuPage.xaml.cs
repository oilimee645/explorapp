using ExplorAppTeo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExplorAppTeo.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Inicio, Title="Inicio", Image="icono_inicio"},
                new HomeMenuItem {Id = MenuItemType.Puertas, Title="Comenzar recorrido", Image="icono_puertas"},
                new HomeMenuItem {Id = MenuItemType.Hoteles, Title="Hoteles", Image="icono_hoteles" },
                new HomeMenuItem {Id = MenuItemType.Restaurantes, Title="Restaurantes", Image="icono_restaurantes"},
                new HomeMenuItem {Id = MenuItemType.Bares, Title="Bares", Image="icono_bares"},
                new HomeMenuItem {Id = MenuItemType.Artesanias, Title="Artesanías", Image="icono_artesanias"},
                new HomeMenuItem {Id = MenuItemType.Entretenimiento, Title="Entretenimiento", Image="icono_entretenimiento"},
                new HomeMenuItem {Id = MenuItemType.Guias, Title="Guias y Agencias", Image="icono_guias"},
                new HomeMenuItem {Id = MenuItemType.Eventos, Title="Eventos", Image="icono_eventos"},
                new HomeMenuItem {Id = MenuItemType.Idioma, Title="Idioma", Image="icono_idioma"},
                //new HomeMenuItem {Id = MenuItemType.Configuracion, Title="Configuración", Image="icono_configuracion"},
                new HomeMenuItem {Id = MenuItemType.Acerca, Title="Acerca", Image="icono_acerca" },

                //new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                //new HomeMenuItem {Id = MenuItemType.About, Title="About" }
            };

            ListViewMenu.ItemsSource = menuItems;

            // CEM - No responde correctamente el selector al usar un Custom Control
            //ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}