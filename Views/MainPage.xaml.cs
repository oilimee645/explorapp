using ExplorAppTeo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MySql.Data.MySqlClient;

namespace ExplorAppTeo.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        MySqlConnection connection = new MySqlConnection("datasource=65.99.252.14;port=3306;username=explorap_emilio;password=Elmejor0211..");
        MySqlCommand command;
        MySqlDataReader mdr;
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Inicio, (NavigationPage)Detail);

        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Inicio:
                        MenuPages.Add(id, new NavigationPage(new InicioPage()));
                        break;
                    case (int)MenuItemType.Puertas:
                        MenuPages.Add(id, new NavigationPage(new PuertasPage()));
                        break;
                    case (int)MenuItemType.Hoteles:
                        MenuPages.Add(id, new NavigationPage(new HotelesPage()));
                        break;
                    case (int)MenuItemType.Restaurantes:
                        MenuPages.Add(id, new NavigationPage(new RestaurantesPage()));
                        break;
                    case (int)MenuItemType.Bares:
                        MenuPages.Add(id, new NavigationPage(new BaresPage()));
                        break;
                    case (int)MenuItemType.Artesanias:
                        MenuPages.Add(id, new NavigationPage(new ArtesaniasPage()));
                        break;
                    case (int)MenuItemType.Entretenimiento:
                        MenuPages.Add(id, new NavigationPage(new EntretenimientoPage()));
                        break;
                    case (int)MenuItemType.Eventos:
                        MenuPages.Add(id, new NavigationPage(new EventosPage()));
                        break;
                    case (int)MenuItemType.Configuracion:
                        MenuPages.Add(id, new NavigationPage(new ConfiguracionPage()));
                        break;
                    case (int)MenuItemType.Idioma:
                        MenuPages.Add(id, new NavigationPage(new IdiomaPage())); /////// 2
                        break;
                    case (int)MenuItemType.Guias:
                        MenuPages.Add(id, new NavigationPage(new GuiasPage())); //////////1
                        break;
                    case (int)MenuItemType.Acerca:
                        MenuPages.Add(id, new NavigationPage(new AcercaPage()));
                        break;
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}