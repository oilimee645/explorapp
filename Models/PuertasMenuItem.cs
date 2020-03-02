using System;
using System.Collections.Generic;
using System.Text;

namespace ExplorAppTeo.Models
{
    public enum PuertasItemType
    {
        Puerta0,
        Puerta1,
        Puerta2,
        Puerta3,
        Puerta4,
        Puerta5
    }

    class PuertasMenuItem
    {
        public PuertasItemType Id { get; set; }

        public string Title { get; set; }
    }
}
