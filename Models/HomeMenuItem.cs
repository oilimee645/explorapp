using System;
using System.Collections.Generic;
using System.Text;

namespace ExplorAppTeo.Models
{
    public enum MenuItemType
    {
        Inicio,
        Puertas,
        Hoteles,
        Restaurantes,
        Bares,
        Artesanias,
        Entretenimiento,
        Eventos,
        Guias,
        Configuracion,
        Acerca,
        Browse,
        Idioma,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }
    }
}
