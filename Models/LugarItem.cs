using SQLite;

namespace ExplorAppTeo.Models
{
    public class LugarItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public string Descrip_Corta { get; set; }
        public string Descrip_Larga { get; set; }
        public string SitioWeb { get; set; }
        public string Direccion { get; set; }
        public string Horario { get; set; }
        public string Telefono { get; set; }
        public string Visitas { get; set; }
        public string Icono { get; set; }
        public string Imagen1 { get; set; }
        public string Imagen2 { get; set; }
        public string Imagen3 { get; set; }

        public string Imagen4 { get; set; }
    }
}
