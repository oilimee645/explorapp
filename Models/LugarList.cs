using System;
using System.Collections.Generic;
using System.Text;

namespace ExplorAppTeo.Models
{
    class LugarList
    {
        List<LugarItem> lugarItems;

        public LugarList()
        {

        }

        public List<LugarItem> List()
        {

            int visitas_Tlacaelel =0;

            
            lugarItems = new List<LugarItem>
            {

                
                new LugarItem
                {

                    /////////////////////////////////////////////RESTAURANTES/////////////////
                    Categoria = "Restaurante",
                    Nombre = "Tlacaelel",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "Exquisita comida típica mexicana con una amplia variedad de platillos, así como servicio de buffet todos los días con barra de ensaladas, plato fuerte y postre.",
                    SitioWeb = "https://www.restaurantetlacaelel.com/",
                    Direccion = "Circuito  pirámides de Teotihuacán  (Entre puerta 1 y 2), San Martín de las Pirámides, México.",
                    Horario = "9am – 7pm",
                    Telefono = "594 9332290",
                    Visitas=visitas_Tlacaelel.ToString(),
                    Icono = "r_tlacaelel_icono.png",
                    Imagen1 = "r_tlacaelel_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "La Catrina",
                    Descrip_Corta = "Comida internacional",
                    Descrip_Larga = "Comida internacional, prehispánica, exótica, a la carta y buffet.",
                    SitioWeb = "https://www.lacatrinateo.com/",
                    Direccion = "Avenida Periférico (Detrás de la Pirámide de la Luna), San Martín de las Pirámides, México.",
                    Horario = "9am – 7pm",
                    Telefono = "55 4013 0194",
                    Visitas="0",
                    Icono = "r_catrina_icono.png",
                    Imagen1 = "r_catrina_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Mi México lindo",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "Mi México lindo es una cocina típica mexicana",
                    SitioWeb = "https://www.facebook.com/rmimexicolindo/",
                    Direccion = "Circuito  pirámides de Teotihuacán (Entre puerta 1 y 2), San Martín de las Pirámides, México.",
                    Horario = "8am – 5pm",
                    Telefono = "594 956 0807",
                     Visitas="0",
                    Icono = "r_mimexicolindo_icono.png",
                    Imagen1 = "r_mimexicolindo_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "El nueve",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "Restaurante mexicano, grill & cafetería, desayunos, comida exótica, 100%familiar. En el servicio contamos con WiFi, música en vivo, perfecto para venir en familia, pareja o amigos.",
                    SitioWeb = "https://www.facebook.com/elnueve.enteotihuacan/",
                    Direccion = "Circuito pirámides, Sección de comida típica No. 9, San Juan Teotihuacán, México",
                    Horario = "8am – 7pm",
                    Telefono = "594 101 6176",
                     Visitas="0",
                    Icono = "r_elnueve_icono.png",
                    Imagen1 = "r_elnueve_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "El Ranchito",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "Restaurante de comida regional teotihuacana, con un excelente jardín-terraza, juegos infantiles y amplio estacionamiento. A sólo 100 m de puerta 2.",
                    SitioWeb = "https://www.facebook.com/El-Ranchito-Teotihuacan-144358422898720/",
                    Direccion = "Circuito  pirámides de Teotihuacán,  San Juan Teotihuacán, México.",
                    Horario = "9am – 5:30pm",
                    Telefono = "594 956 1583",
                     Visitas="0",
                    Icono = "r_elranchito_icono.png",
                    Imagen1 = "r_elranchito_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Gran Teocalli",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "Restaurante Mexicano, somos la mejor opción a visitar, contamos con estacionamiento y juegos infantiles, además de una gran variedad de productos para usted.",
                    SitioWeb = "https://www.facebook.com/GranTeocalliRM/",
                    Direccion = "km 21.5 Autopista Mexico-Piramides, San Juan Teotihuacán, México.",
                    Horario = "9am – 6pm",
                    Telefono = "594 956 3267",
                     Visitas="0",
                    Icono = "r_granteocalli_icono.png",
                    Imagen1 = "r_granteocalli_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Mayahuel",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "Comida típica mexicana.",
                    SitioWeb = "https://www.mayahuelteotihuacan.com/",
                    Direccion = "Circuito  pirámides de Teotihuacán,  San Martín de las Pirámides, México.",
                    Horario = "9:30am – 6pm",
                    Telefono = "594 958 2836",
                     Visitas="0",
                    Icono = "r_mayahuel_icono.png",
                    Imagen1 = "r_mayahuel_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
             new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "La Gruta",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "Ven a La Gruta y vive una experiencia mística mientras saboreas deliciosos platillos con los ingredientes de la gastronomía local y la herencia culinaria de épocas prehispánicas.",
                    SitioWeb = "http://www.lagruta.mx",
                    Direccion = "Circuito Arqueologico, Avenida del Puente, San Francisco Mazapa, México.",
                    Horario = "11am – 5pm",
                    Telefono = "594 956 0127",
                     Visitas="0",
                    Icono = "r_lagruta_icono.png",
                    Imagen1 = "r_lagruta_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
             new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Rancho Azteca",
                    Descrip_Corta = "Comida internacional",
                    Descrip_Larga = "Conquistamos tu paladar con nuestros sabores inigualables!",
                    SitioWeb = "https://www.facebook.com/ranchoaztecaoficial/",
                    Direccion = "Circuito pirámides, San Juan Teotihuacán, México.",
                    Horario = "8am – 4pm",
                    Telefono = "594 956 8229",
                     Visitas="0",
                    Icono = "r_ranchoazteca_icono.png",
                    Imagen1 = "r_ranchoazteca_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
             new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "La Cabaña desde 1970",
                    Descrip_Corta = "Restaurante & Grill",
                    Descrip_Larga = "Cafetería, Restaurant & Grill",
                    SitioWeb = "https://www.facebook.com/lacabanadesde1970/?ref=timeline_chaining",
                    Direccion = "Circuito  pirámides de Teotihuacán,  San Martín de las Pirámides, México.",
                    Horario = "9am – 7pm",
                    Telefono = "594 958 6044",
                     Visitas="0",
                    Icono = "r_lacabana_icono.png",
                    Imagen1 = "r_lacabana_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
             new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Hacienda El Ritual",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "Coctelería Orgánica. Café, bar y restaurante con un estilo antiguo.",
                    SitioWeb = "https://www.facebook.com/StaffRitual/?ref=timeline_chaining",
                    Direccion = "Av.Centenario No.17 , San Juan Teotihuacán,México.",
                    Horario = "1pm – 9pm",
                    Telefono = "55 1007 0438",
                     Visitas="0",
                    Icono = "r_haciendaelritual_icono.png",
                    Imagen1 = "r_haciendaelritual_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
             new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Conejo en la luna",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "Al visitarnos disfrutaras de una amplia gama de mezcales artesanales o ancestrales acompañado de exquisitos platillos, también conocerás su proceso e historia y tendrás la oportunidad de llevarte a casa el mezcal de la región que más te guste.",
                    SitioWeb = "https://www.facebook.com/mezcalesartesanalescl/",
                    Direccion = "Circuito  pirámides de Teotihuacán  (Entre puerta 1 y 2) , San Martín de las Pirámides, México.",
                    Horario = "8am – 5pm",
                    Telefono = "594 956 8529",
                     Visitas="0",
                    Icono = "r_conejoenlaluna_icono.png",
                    Imagen1 = "r_conejoenlaluna_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
             new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "El Jaguar",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "Restaurante/Bar Familiar, Cocina Tradicional Mexicana. Danza Prehispánica y Música en vivo.",
                    SitioWeb = "https://www.facebook.com/ElJaguarTeotihuacan/",
                    Direccion = "Periferico No. 208,  San Martin de las Pirámides, México.",
                    Horario = "9am – 6pm",
                    Telefono = "594 958 2804",
                     Visitas="0",
                    Icono = "r_eljaguar_icono.png",
                    Imagen1 = "r_eljaguar_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
             new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "La Chorcha",
                    Descrip_Corta = "Asadero y parrilla",
                    Descrip_Larga = "ven y conoce asadero & parrilla “la chorcha” no te vas arrepentir !",
                    SitioWeb = "https://www.facebook.com/lachorchateoti/",
                    Direccion = "Av. Periferico No. 149 San Martin de las Piramides, México.",
                    Horario = "9am – 6pm",
                    Telefono = "55 5907 3365",
                     Visitas="0",
                    Icono = "r_lachorcha_icono.png",
                    Imagen1 = "r_lachorcha_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
             new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "El Mitotl",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "Restaurante Familiar con un toque de folklor Mexicano.Un concepto diferente ubicado a un costado de las pirámides de Teotihuacán.",
                    SitioWeb = "https://www.facebook.com/ElMitotl/",
                    Direccion = "Circuito Pirámides, San Sebastián Xolalpa, México.",
                    Horario = "8am – 5pm",
                    Telefono = "594 956 1444",
                     Visitas="0",
                    Icono = "r_elmitotl_icono.png",
                    Imagen1 = "r_elmitotl_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Meztli",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "Comida típica con el sabor a México y comida  Internacional.",
                    SitioWeb = "https://meztli.business.site/",
                    Direccion = "Circuito  pirámides de Teotihuacán (Detrás de la pirámide de la luna),  San Martín de las Pirámides, México.",
                    Horario = "9am – 6pm",
                    Telefono = "594 958 2339",
                     Visitas="0",
                    Icono = "r_meztli_icono.png",
                    Imagen1 = "r_meztli_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Café Teo",
                    Descrip_Corta = "Cafetería Artesanal",
                    Descrip_Larga = "Productos 100% mexicanos y de la región. Ven a deleitar tu paladar con nuestro rico sabor Teotihuacano.",
                    SitioWeb = "https://www.facebook.com/Cafeteotihuacan/",
                    Direccion = "Av.  Del puente, San Juan Teotihuacán, México.",
                    Horario = "5:30pm – 10:30pm",
                    Telefono = "55 1910 6876",
                     Visitas="0",
                    Icono = "r_cafeteo_icono.png",
                    Imagen1 = "r_cafeteo_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "La Choza de Quetzalcóatl",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "La choza de Quetzalcoátl, es un restaurante de la región de Teotihuacán, inspirado en la mezcla de colores y toque de sabores. Nuestro menú se basa en la cocina típica regional mexicana.",
                    SitioWeb = "https://www.facebook.com/chozarestaurant/",
                    Direccion = "Carretera México - Tulancingo km25.5 (3,38 km)55835 San Juan Teotihuacán, México.",
                    Horario = "8:30am – 6pm",
                    Telefono = "5541761316 o 5529372951",
                     Visitas="0",
                    Icono = "r_lachozadequet_icon.png",
                    Imagen1 = "r_lachozadequet_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Don Mincho",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "Servicio a domicilio, promociones todo el año, excelentes instalaciones, servicio de bar y calidad en nuestro servicio.",
                    SitioWeb = "https://www.donmincho.com.mx/?fbclid=IwAR3podeEsfqTp2hSl962rdF0cU_fE8XvPMG5vwGGjj58OxGUq_mdd_4ebyY",
                    Direccion = "Allende No. 7 , San Juan Teotihuacán, México.",
                    Horario = "9am – 9pm",
                    Telefono = "594 9561793",
                     Visitas="0",
                    Icono = "r_mincho_icono.png",
                    Imagen1 = "r_mincho_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Rancho cofradía",
                    Descrip_Corta = "Restaurant Campestre",
                    Descrip_Larga = "Restaurant Campestre y Jardín de Eventos Sociales. Ven a enamorarte de este hermoso lugar, conoce la magia y el misticismo del rancho.",
                    SitioWeb = "https://www.facebook.com/restaurantranchocofradia/",
                    Direccion = "Calle Adolfo López Mateos, San Juan Teotihuacán, Mexico.",
                    Horario = "9am – 9pm",
                    Telefono = "55 3020 7521",
                     Visitas="0",
                    Icono = "r_ranchocofradia_icono.png",
                    Imagen1 = "r_ranchocofradia_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Los Ahuehuetes",
                    Descrip_Corta = "Cocina mexicana fusión",
                    Descrip_Larga = "Cocina mexicana fusión, cortes americanos, mariscos, pastas, postres, vinos, mezcal, cerveza artesanal y un servicio excepcional.",
                    SitioWeb = "https://www.restaurantelosahuehuetes.com/",
                    Direccion = "Lopez mateos No.16, San Juan Teotihuacan, México.",
                    Horario = "8am – 10pm",
                    Telefono = "594 956 1339",
                     Visitas="0",
                    Icono = "r_losahuehuetes_icono.png",
                    Imagen1 = "r_losahuehuetes_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "La cabaña 24",
                    Descrip_Corta = "Restaurante & Grill",
                    Descrip_Larga = "La cabaña No. 24 le ofrece una gran variedad de comida típica, antojitos mexicanos y platillos exóticos.",
                    SitioWeb = "https://www.facebook.com/lacabana24teotihuacan/?ref=br_rs",
                    Direccion = "Circuito pirámides (detrás de la pirámide del sol), San  Juan Teotihuacán, México.",
                    Horario = "9am – 6pm",
                    Telefono = "594 101 6083",
                     Visitas="0",
                    Icono = "r_lacabana24_icono.png",
                    Imagen1 = "r_lacabana24_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Mesón Los Arcos Teotihuacán",
                    Descrip_Corta = "Comida típica mexicana",
                    Descrip_Larga = "¡Estamos comprometidos con darte un servicio de calidad, y queremos que disfrutes de nuestros platillos y agradable lugar!",
                    SitioWeb = "https://mesonlosarcosteotihuacan.negocio.site/website/mesonlosarcosteotihuacan/",
                    Direccion = "Zumpango No. 17, Evangelista, San Juan Teotihuacan, México.",
                    Horario = "8:30am – 6pm",
                    Telefono = "594 933 2317",
                     Visitas="0",
                    Icono = "r_mesonlosarcos_icono.png",
                    Imagen1 = "r_mesonlosarcos_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Internacional Tlaxko",
                    Descrip_Corta = "Comida internacional",
                    Descrip_Larga = "Contamos con el más delicioso menú de alimentos clásicos disponibles en la zona de Teotihuacán. Nuestro restaurante cuenta con un ambiente cálido, acogedor y amistoso personal que se asegura, de que usted disfrute de una placentera experiencia gastronómic",
                    SitioWeb = "http://restintertlaxko.com.mx/sample-page/",
                    Direccion = "Circuito de las Pirámides 12, San Martin de las Pirámides, México.",
                    Horario = "12pm – 5pm",
                    Telefono = "594 958 3074",
                     Visitas="0",
                    Icono = "r_tlaxko_icono.png",
                    Imagen1 = "r_tlaxko_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "El Vegetariano",
                    Descrip_Corta = "Restaurante vegetariano",
                    Descrip_Larga = "Restaurante vegetariano de comida rápida.",
                    SitioWeb = "https://www.facebook.com/vegetarianoteotihuacan/",
                    Direccion = "Av. Hidalgo No. 16, San Juan Teotihuacán, México.",
                    Horario = "11:30am – 6pm",
                    Telefono = "55 2720 9944",
                     Visitas="0",
                    Icono = "r_vegetariano_icon.png",
                    Imagen1 = "r_vegetariano_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Antares",
                    Descrip_Corta = "Restaurante gourmet",
                    Descrip_Larga = "Somos un café y restaurante gourmet con 15 años de existencia donde disfrutaras deliciosos platillos y barra cafe gourmet.",
                    SitioWeb = "https://www.facebook.com/antarestykfgourmet/?ref=br_rs",
                    Direccion = "Av. Cuauhtemoc y guadalupe victoria, San Juan Teotihuacán, México.",
                    Horario = "8:30pm – 7pm",
                    Telefono = "55 4282 1643",
                     Visitas="0",
                    Icono = "r_antares_icono.png",
                    Imagen1 = "r_antares_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "Triceltra Bistro",
                    Descrip_Corta = "Café",
                    Descrip_Larga = "Ven y disfruta de un nuevo concepto culinario en Teotihuacán, donde el Chef “Elien Afiune” te llevará a degustar exquisitos platillos, snaks, pastelería fina, entre otras sorpresas.",
                    SitioWeb = "https://www.facebook.com/TriceltaBistro/?ref=timeline_chaining",
                    Direccion = "Guadalupe Victoria No.17 Local 8, San Juan Teotihuacán, México.",
                    Horario = "8am – 9pm",
                    Telefono = "594 933 2246",
                     Visitas="0",
                    Icono = "r_tricelta_icono.png",
                    Imagen1 = "r_tricelta_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 new LugarItem
                {
                    Categoria = "Restaurante",
                    Nombre = "El Portón",
                    Descrip_Corta = "Restaurante",
                    Descrip_Larga = "Restaurante Familiar a 3 min de la zona arqueológica de Teotihuán. Contamos con un menú diferente todos los días",
                    SitioWeb = "https://www.facebook.com/elportonteotihuacan/",
                    Direccion = "San Martín de las Pirámides",
                    Horario = "9am – 7pm",
                    Telefono = "594 958 3466",
                     Visitas="0",
                    Icono = "r_elporton_icon.png",
                    Imagen1 = "r_elporton_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
///////////////////////////////////////////////////BARES//////////////////////////////////////////////////////////////
                 new LugarItem
                {
                    Categoria = "Bar",
                    Nombre = "El Nahual",
                    Descrip_Corta = "Bar",
                    Descrip_Larga = "El Nahual es un multi-espacio que fusiona la experiencia cultural de un foro, el ambiente nocturno de un bar y el sazón típico de una cocina mexicana.",
                    SitioWeb = "https://www.facebook.com/ForoNahualTeotihuacan/?ref=br_rs",
                    Direccion = "Avenida Periférico No.222, San Juan Teotihuacá, México.",
                    Horario = "2pm – 12am",
                    Telefono = "594 958 5793",

                    Icono = "b_nahual_icono.png",
                    Imagen1 = "b_nahual_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 new LugarItem
                {
                    Categoria = "Bar",
                    Nombre = "Factory Pirámides",
                    Descrip_Corta = "Bar",
                    Descrip_Larga = "Disfruta de un lugar nuevo. ¡Alitas, rock en vivo y excelente ambiente!",
                    SitioWeb = "https://www.facebook.com/factoryteotihuacan/",
                    Direccion = "Av. Tuxpan esquina 16 de septiembre,  San Martín de las Pirámides, México.",
                    Horario = "3pm – 10pm",
                    Telefono = "55 6075 7899",

                    Icono = "b_factory_icono.png",
                    Imagen1 = "b_factory_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 new LugarItem
                {
                    Categoria = "Bar",
                    Nombre = "Jacare",
                    Descrip_Corta = "Bar & Snack",
                    Descrip_Larga = "Centro recreacional para la convivencia e intercambio social para mayores de edad, basado en la oportunidad de vivir la experiencia del cambio en los productos espirituales tradicionales y ancestrales.",
                    SitioWeb = "https://jacare-bs.negocio.site/#details",
                    Direccion = "Teotihuacan centro, San Juan Teotihuacán, México.",
                    Horario = "2:30pm – 2am",
                    Telefono = "55 3996 5463",

                    Icono = "b_jacare_icono.png",
                    Imagen1 = "b_jacare_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 new LugarItem
                {
                    Categoria = "Bar",
                    Nombre = "La salamandra",
                    Descrip_Corta = "El mejor lugar",
                    Descrip_Larga = "El mejor lugar lo hace la mejor gente: “ Gente como tu “",
                    SitioWeb = "https://www.facebook.com/lasalamandra.bardance/",
                    Direccion = "Circuito pirámides de Teotihuacan (Detrás de la pirámide de a luna), San Martín de las Pirámides, México.",
                    Horario = "Viernes y sábado 7pm",
                    Telefono = "5534696552",

                    Icono = "b_salamandra_icono.png",
                    Imagen1 = "b_salamandra_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 new LugarItem
                {
                    Categoria = "Bar",
                    Nombre = "Bar & Grill Xoloitzcuintle",
                    Descrip_Corta = "Bar & Grill",
                    Descrip_Larga = "Xoloitzcuintle es un lugar ubicado frente a la zona arqueológica de Teotihuacán, en el cual podrás disfrutar de un buen ambiente nocturno y de comida mexicana e internacional.",
                    SitioWeb = "https://www.facebook.com/xolobarteotihuacan/",
                    Direccion = "Direccion: Av. Periferico Sur S/N San Sebastián Xolalpa, Mexico, Mexico",
                    Horario = "Miercoles a Domingo 9am – 3pm",
                    Telefono = "5541761316 o 5529372951",

                    Icono = "b_xoloitzcuintle_icon.png",
                    Imagen1 = "b_xoloitzcuintle_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 new LugarItem
                {
                    Categoria = "Bar",
                    Nombre = "La Xoma",
                    Descrip_Corta = "Pulquería artesanal",
                    Descrip_Larga = "Pulque artesanal, Cerveza artesanal, Tequila, Mezcal, Licores  ymás...",
                    SitioWeb = "https://www.facebook.com/LaXomaOficial/?ref=br_rs",
                    Direccion = "Av. de los deportes No.8, San Martín de las Pirámides, México.",
                    Horario = "10am – 9pm",
                    Telefono = "594 108 1505",

                    Icono = "b_laxoma_icono.png",
                    Imagen1 = "b_laxoma_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 new LugarItem
                {
                    Categoria = "Bar",
                    Nombre = "La Choperia Teotihuacán",
                    Descrip_Corta = "Bar",
                    Descrip_Larga = "Es el lugar ideal para ir en pareja, con amigos o a cerrar un negocio. Buena comida,buena cerveza y magnifico ambiente musical ¡promociones diarias!",
                    SitioWeb = "https://www.facebook.com/ChoperiaTeotihuacan/",
                    Direccion = "Circuito  pirámides de Teotihuacán,  San Juan Teotihuacán, México.",
                    Horario = "2pm – 12am",
                    Telefono = "5949568656",

                    Icono = "b_choperia_icono.png",
                    Imagen1 = "b_choperia_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 new LugarItem
                {
                    Categoria = "Bar",
                    Nombre = "El meson de tenerife",
                    Descrip_Corta = "Restaurante Bar",
                    Descrip_Larga = "Un lugar acogedor... donde podrás deleitar tu paladar. ¡Ven y prueba nuestros deliciosos Platillos y Snacks!",
                    SitioWeb = "https://www.facebook.com/ElMesonDeTenerife/?ref=timeline_chaining",
                    Direccion = "Hidalgo No.3 Col. Centro, interior plaza pico del Tenerife, San Juan Teotihuacán, México.",
                    Horario = "",
                    Telefono = "594 956 8616",

                    Icono = "b_elmeson_icono.png",
                    Imagen1 = "b_elmeson_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 new LugarItem
                {
                    Categoria = "Bar",
                    Nombre = "Burro Chelero",
                    Descrip_Corta = "Bar- Discoteca",
                    Descrip_Larga = "Discoteca",
                    SitioWeb = "https://www.facebook.com/burrochelerooficial/",
                    Direccion = "Callejon del Veinticinco Regimiento, San Juan Teotihuacan, México.",
                    Horario = "11am – 11pm",
                    Telefono = "5614536992",

                    Icono = "b_burrochelero_icono.png",
                    Imagen1 = "b_burrochelero_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 new LugarItem
                {
                    Categoria = "Bar",
                    Nombre = "Aldea Vikinga San Juan Teotihuacán",
                    Descrip_Corta = "Bar",
                    Descrip_Larga = "Ven a disfrutar de una cerveza con música en vivo en este bar con una temática vikinga. ¡Siempre tenemos promociones”",
                    SitioWeb = "https://www.facebook.com/AldeaVikinga/?ref=br_rs",
                    Direccion = "Adolfo López Mateos No. 18, San Juan Teotihuacán, México.",
                    Horario = "2pm – 11pm",
                    Telefono = "594 108 0541",

                    Icono = "b_aldeavikinga_icono.png",
                    Imagen1 = "b_aldeavikinga_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 new LugarItem
                {
                    Categoria = "Bar",
                    Nombre = "Ixaya",
                    Descrip_Corta = "Bar & Grill",
                    Descrip_Larga = "El restaurante más divertido y sofisticado de Teotihuacán.  Ven y disfruta exquisitos platillos mexicanos a nivel gourmet y coctelería. ¡TE ESPERAMOS!",
                    SitioWeb = "https://www.facebook.com/ixaya.restaurante/?ref=br_rs",
                    Direccion = "Circuito  pirámides de Teotihuacán,  San Juan Teotihuacán, México.",
                    Horario = "10:30am – 7pm",
                    Telefono = "594 101 8361",

                    Icono = "b_ixaya_icono.png",
                    Imagen1 = "b_ixaya_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 new LugarItem
                {
                    Categoria = "Bar",
                    Nombre = "Las Fridas",
                    Descrip_Corta = "Bar",
                    Descrip_Larga = "El mejor ambiente en el mejor lugar listo para celebrar tus fiestas charlas con los amigos, ligar y mucho más",
                    SitioWeb = "https://www.facebook.com/lasfridasteotihuacan/?ref=br_rs",
                    Direccion = "Calle 25 Regimiento, No 4, San Juan Teotihuacan, México.",
                    Horario = "11am – 12am",
                    Telefono = "594 956 8683",

                    Icono = "b_fridas_icono.png",
                    Imagen1 = "b_fridas_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                /* new LugarItem
                {
                    Categoria = "Bar",
                    Nombre = "Galet Club Piramides",
                    Descrip_Corta = "Show Center Teotihuacán",
                    Descrip_Larga = "El Mejor Antro Bar Karaoke Y Centro De Espectáculos En San Martín De Las Pirámides.",
                    SitioWeb = "https://www.facebook.com/GaletPiramides/?ref=timeline_chaining",
                    Direccion = "Avenida Periférico, San Martín de las Pirámides, México.",
                    Horario = "Jueves a Sabado 8pm – 2am",
                    Telefono = "55 6932 8662",

                    Icono = "b_galet_icono.png",
                    Imagen1 = "b_galet_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },*/
////////////////////////////////////////////////////Tiendas de artesanía//////////////////////////////////////////////
            new LugarItem
                {
                    Categoria = "Artesanía",
                    Nombre = "El Quetzal",
                    Descrip_Corta = "Joyería",
                    Descrip_Larga = "¡Vive San Martín de las Pirámides!",
                    SitioWeb = "No cuenta con sitio web",
                    Direccion = "Circuito arqueológico de las pirámides de Teotihuacán, Estado de México (Entre puerta 1 y 2",
                    Horario = "9am – 7pm",
                    Telefono = "55 9139 4130",

                    Icono = "a_quetzal_icono.png",
                    Imagen1 = "a_quetzal_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Artesanía",
                    Nombre = "Casa museo de las piedras",
                    Descrip_Corta = "Joyería de piedras preciosas y semi preciosas.",
                    Descrip_Larga = "Joyería de piedras preciosas y semi preciosas. Explicación de talleres y de piezas de arte, degustación de tequila y pulque.",
                    SitioWeb = "No cuenta con sitio web",
                    Direccion = "Av. Pirámides s/n (A 100 metros de la puerta1), San Juan Teotihuacán, México.",
                    Horario = "9am – 5pm",
                    Telefono = "594 933 2181",
                  
                    Icono = "a_casadepiedra_icono.png",
                    Imagen1 = "a_casadepiedra_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Artesanía",
                    Nombre = "Grupo Teotihuacano México",
                    Descrip_Corta = "Proctos artesanales",
                    Descrip_Larga = "Elaboración de productos derivados del nopal, tuna y xoconostle: licores, salsas,mermeladas ,dulces y botanas productos naturales sin conservadores.",
                    SitioWeb = "https://www.facebook.com/grupo.teotihucano.mex/",
                    Direccion = "Plan de san Luis No.48, San Martín de las Pirámides, México.",
                    Horario = "8am – 6pm",
                    Telefono = "5540976710",
                   
                    Icono = "a_grupoteoti_icono.png",
                    Imagen1 = "a_grupoteoti_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Artesanía",
                    Nombre = "Grupo Agroindustrial Teotihuacano",
                    Descrip_Corta = "Proctos artesanales",
                    Descrip_Larga = "Productos derivados del Nopal Tuna y Xoconostle: Licores, mermeladas, salsas, gomitas, polvo deshidratado ¡entre otros más!",
                    SitioWeb = "https://www.facebook.com/grupoteotihuacano.agrondustrial/",
                    Direccion = "Francisco I Madero No.5, San Martín de las Pirámides, México.",
                    Horario = "Siempre abierto",
                    Telefono = "594 958 3089",
                   
                    Icono = "a_grupoagro_icono.png",
                    Imagen1 = "a_grupoagro_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
////////////////////////////////////////////////////////////Entretenimiento///////////////////////////////////////////
            new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Globos aerostáticos México",
                    Descrip_Corta = "Vuelo en globo",
                    Descrip_Larga = "Disfruta de la experiencia de volar en globo aerostático",
                    SitioWeb = "https://instagram.com/globos_aereostaticos_mexico?igshid=vqawb49z3l6u",
                    Direccion = "Carretera federal mexico-tulancingo",
                    Horario = "Siembre abierto",
                    Telefono = "5541761316 o 5529372951",

                    Icono = "e_globosaero_icon.png",
                    Imagen1 = "e_globosaero_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Fiesta mágica en Teotihuacán",
                    Descrip_Corta = "Fiesta mágica en Teotihuacán",
                    Descrip_Larga = "Fiesta Mágica es la experiencia que cautiva tus 5 sentidos, transportándote a nuestro pasado, para que juntos a través de los espectáculos descubramos nuestras raíces.",
                    SitioWeb = "http://www.eventosquehacenhistoria.com/",
                    Direccion = "Calle de la barranca #1, esquina con avenida pirámides, Purificación, Teotihuacán, MEX.",
                    Horario = "Siempre abierto",
                    Telefono = "5584516526",
                    
                    Icono = "e_fiestamagica_icono.png",
                    Imagen1 = "e_fiestamagica_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Teotihuacan desconocido",
                    Descrip_Corta = "Vuelo en globo",
                    Descrip_Larga = "Agencia encargada de brindar servicio de vuelos en globos sobre el valle de Teotihuacán, nos diferenciamos y estamos especializados en brindar el mejor servicio para que nuestros clientes vivan una experiencia inolvidable.",
                    SitioWeb = "https://www.facebook.com/teotihuacandesconocido/",
                    Direccion = "Calle Pirámides 5, San Sebastián Xolalpa, Méx.",
                    Horario = "5am – 11pm",
                    Telefono = "5541761316 o 5529372951",

                    Icono = "e_globodesconocido_icon.png",
                    Imagen1 = "e_globodesconocido_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },

                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Jardín de las cactáceas",
                    Descrip_Corta = "Parque temático",
                    Descrip_Larga = "Parque temático creado para preservar la diversidad de cactáceas de nuestro país, contamos con tirolesa, cavernas, áreas verdes y actividades interactivas.",
                    SitioWeb = "https://www.facebook.com/Jard%C3%ADn-de-Cact%C3%A1ceas-Teotihuacan-1022038897822612/",
                    Direccion = "Av. Pirámides, San Juan Teotihuacan, México.",
                    Horario = "9am – 5pm",
                    Telefono = "55 3145 9311",
                   
                    Icono = "e_Jardindecactaceas_icono.png",
                    Imagen1 = "e_Jardindecactaceas_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Sky Ballons Mexico",
                    Descrip_Corta = "Vuelo en globo",
                    Descrip_Larga = "Los mejores vuelos en Globo en Teotihuacán. Encuéntranos a solo 40 minutos de la Ciudad de México, ven a vivir la mejor experiencia, solo en Sky Balloons.",
                    SitioWeb = "https://www.skyballoons.mx/",
                    Direccion = "Ctra. Federal México-Tulancingo Km. 28, San Juan Teptihuacán. México.",
                    Horario = "Siempre abierto",
                    Telefono = "55 5870 3544",

                    Icono = "e_SkyBallons_icono.png",
                    Imagen1 = "e_SkyBallons_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Pulques Don Toño",
                    Descrip_Corta = "Experiencia Visita guiada",
                    Descrip_Larga = "Don Antonio Campos Vega es uno de los productores de pulque y derivados del maguey, más reconocidos del Valle de México, ya que usa la técnica ancestral, lo cual da como resultado pulque exquisito de la mejor calidad.",
                    SitioWeb = "https://www.facebook.com/Pulques-Don-To%C3%B1o-203365010570881/?ref=br_rs",
                    Direccion = "Sin Dirección",
                    Horario = "10am – 6pm",
                    Telefono = "55 1032 1153",

                    Icono = "e_pulquesdontono_icono.png",
                    Imagen1 = "e_pulquesdontono_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Pedalea Teotihuacán",
                    Descrip_Corta = "Recorridos",
                    Descrip_Larga = "Renta de bicicletas para recorridos en la zona arqueológica de Teotihuacán y sus alrededores.",
                    SitioWeb = "https://www.facebook.com/PedaleaTeotihuacan/",
                    Direccion = "Carretera Teotihuacán-Pirámides S/N. Purificación. San Juan Teotihuacán, México.",
                    Horario = "9am – 5pm",
                    Telefono = "55 8335 3635",

                    Icono = "e_Pedaleateotihuacan_icono.png",
                    Imagen1 = "e_Pedaleateotihuacan_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Noches Mágicas en Teotihuacán.",
                    Descrip_Corta = "Experiencia",
                    Descrip_Larga = "Se parte de este nuevo proyecto nocturno. Ven y vive una experiencia inolvidable con tu familia y/o amigos en la ciudad de los Dioses.",
                    SitioWeb = "https://www.facebook.com/NochesMagicasTeotihuacan/",
                    Direccion = "San Martin de las Pirámides, México.",
                    Horario = "9am – 5pm",
                    Telefono = "55 4517 0546",

                    Icono = "e_Nochesmagicas_icono.png",
                    Imagen1 = "e_Nochesmagicas_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Tonalli",
                    Descrip_Corta = "Parque temático",
                    Descrip_Larga = "Certificado de recreación y coordinación de grupos. Acreditación de guías turísticos por SECTUR. Primer lugar en visitas escolares en Teotihuacán.",
                    SitioWeb = "https://www.facebook.com/visitasdidacticas/?ref=br_rs",
                    Direccion = "Carretera Teotihuacan-Piramides , San Juan Teotihuacán, México.",
                    Horario = "9am – 5pm",
                    Telefono = "55 3145 9311",

                    Icono = "e_Tonalli_icono.png",
                    Imagen1 = "e_Tonalli_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Reino Animal",
                    Descrip_Corta = "Parque temático",
                    Descrip_Larga = "Somos un parque sustentable dedicado al entretenimiento familiar donde podrás interactuar con 130 especies animales viviendo experiencias únicas y disfrutar actividades en donde todos los integrantes de ella puedan participar.",
                    SitioWeb = "https://www.facebook.com/ReinoAnimalMx/",
                    Direccion = "Camino a Belén Santa María S/N, Oxtotipac,  Otumba, México.",
                    Horario = "10am – 6pm",
                    Telefono = "595 952 1111",

                    Icono = "e_Reinoanimal_icono.png",
                    Imagen1 = "e_Reinoanimal_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Teotihuacán en cuatrimoto",
                    Descrip_Corta = "Recorridos",
                    Descrip_Larga = "Paseo en bicicleta y cuatrimoto, admira Teotihuacán de una manera diferente, divierte a lo grande. ¡Teotihuacán es más que las pirámides!",
                    SitioWeb = "https://www.facebook.com/teotihuacan.en.cuatrimoto/",
                    Direccion = "Teotihuacan, San Juan Teotihuacán, México.",
                    Horario = "9am – 3pm",
                    Telefono = "55 6148 2348",

                    Icono = "e_Teotihucanencuatrimoto_icono.png",
                    Imagen1 = "e_Teotihucanencuatrimoto_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Bicicletas antiguas",
                    Descrip_Corta = "Recorridos",
                    Descrip_Larga = "Renta de bicicletas para recorridos en la zona arqueológica de Teotihuacán y sus alrededores.",
                    SitioWeb = "https://www.facebook.com/Bicicletasantiguasteotihuacan/",
                    Direccion = "Carretera Teotihuacan-Piramides, San Juan Teotihuacán, México.",
                    Horario = "9am- 6pm",
                    Telefono = "55 2540 5278",

                    Icono = "e_Bicicletasantiguas_icono.png",
                    Imagen1 = "e_Bicicletasantiguas_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Aerodiverti",
                    Descrip_Corta = "Vuelo en globo",
                    Descrip_Larga = "Vuelos panorámicos en Globo Aerostático sobrevolando las Pirámides de Teotihuacán.",
                    SitioWeb = "https://aerodiverti.com.mx/",
                    Direccion = "Cda. Rosendo Arnaiz s/n, San Martín de las Pirámides, México.",
                    Horario = "6am – 10pm",
                    Telefono = "55 1852 0509",

                    Icono = "e_erodiverti_icono.png",
                    Imagen1 = "e_erodiverti_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Volar en globo",
                    Descrip_Corta = "Vuelo en globo",
                    Descrip_Larga = "Somos una excelente opción para que puedas vivir ¡tu sueño en globo! Te ofrecemos el mejor servicio personalizado, con personal capacitado para atender tus requerimientos de diversión segura.",
                    SitioWeb = "https://volarenglobo.com.mx/tienda/",
                    Direccion = "Carretera Libre Tulancingo km 28, San Martín de las Pirámides, México.",
                    Horario = "6am – 11pm",
                    Telefono = "55 5870 6611",

                    Icono = "e_Volarenglobo_icono.png",
                    Imagen1 = "e_Volarenglobo_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Globos aerostáticos Teotihuacan",
                    Descrip_Corta = "Vuelo en globo",
                    Descrip_Larga = "Ven a volar con nosotros en una mágica travesía en globo sobre el valle de Teotihuacán. Prestamos gran atención a la seguridad y calidad de nuestros globos así como la experiencia de cada uno nuestros pilotos.",
                    SitioWeb = "https://www.facebook.com/flyingpicturesmexico/",
                    Direccion = "Carretera Libre Tulancingo km 28,  San Martín de las Pirámides, México.",
                    Horario = "9am – 10pm",
                    Telefono = "55 5362 5595",

                    Icono = "e_Globosaerostaticosteotihuacan_icono.png",
                    Imagen1 = "e_Globosaerostaticosteotihuacan_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Aeroxplora Teotihuacan",
                    Descrip_Corta = "Vuelo en globo",
                    Descrip_Larga = "Contamos con más de 23 años de experiencia en vuelos en Globo Aerostático tanto en México como en el extranjero, realizando tours aéreos y vuelos publicitarios en todo el territorio nacional desde 1990.",
                    SitioWeb = "http://www.aeroxplora.com/?fbclid=IwAR3Sgr1-iFVhSwwwDBgC9RqYr7XgdG6ufR9-sJKDxAyS9-yov2N3VR_TaE0",
                    Direccion = "Carretera Libre Tulancingo km 28, San Martín de las Pirámides, México.",
                    Horario = "9am – 6pm",
                    Telefono = "66073793",

                    Icono = "e_Aeroxplorateotihuacan_icono.png",
                    Imagen1 = "e_Aeroxplorateotihuacan_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Teotihuacán Xtremo",
                    Descrip_Corta = "Agencia Turística",
                    Descrip_Larga = "Agencia de turismo en Teotihuacan, que busca que sus clientes conozcan un lado diferente de nuestra ciudad milenaria.",
                    SitioWeb = "https://www.facebook.com/teotixtremo/?ref=br_rs",
                    Direccion = "Sin Dirección",
                    Horario = "Siempre abierto",
                    Telefono = "55 4339 1560",

                    Icono = "e_Teotihuacanxtremo_icono.png",
                    Imagen1 = "e_Teotihuacanxtremo_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Aventura en Globos",
                    Descrip_Corta = "Vuelo en globo",
                    Descrip_Larga = "Ofrecemos vuelos Panorámicos en Globo Aerostático sobre el valle de Teotihuacan, una manera diferente de ver zona arqueológica. Manejamos: Vuelo Compartidos, Vuelo Privados, Vuelo Vip, Vuelo Madrugadores; también diferentes actividades, como paseos en bic",
                    SitioWeb = "https://www.facebook.com/aventuraenglobos/",
                    Direccion = "Privada de niños heroes No.3, San Martín de las Pirámides, México.",
                    Horario = "9am – 6pm",
                    Telefono = "55 5198 6399",

                    Icono = "e_aventuraenglobos_icono.png",
                    Imagen1 = "e_aventuraenglobos_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Ruta mágica de Teotihuacán",
                    Descrip_Corta = "Agencia Turística",
                    Descrip_Larga = "Te acerca al maravilloso pasado ancestral de la ciudad de los dioses en Teotihuacán combinando aventura, conocimiento, emoción, alegría, intensidad de vivir experiencias inolvidables al visitarnos",
                    SitioWeb = "https://www.facebook.com/rutamagicateo/",
                    Direccion = "Sin Dirección",
                    Horario = "9am – 9pm",
                    Telefono = "594 101 8160",

                    Icono = "e_Rutamagica_icono.png",
                    Imagen1 = "e_Rutamagica_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Travel Teotihuacán",
                    Descrip_Corta = "Agencia Turística",
                    Descrip_Larga = "Disfrutaras de experiencias  que nunca olvidaras  en uno de los mejores lugares turísticos de méxico .... Teotihuacán",
                    SitioWeb = "https://www.facebook.com/travelteotihuacan/?ref=br_rs",
                    Direccion = "San Juan Teotihuacan, México.",
                    Horario = "Siempre abierto",
                    Telefono = "55 2046 3852",

                    Icono = "e_Travelteotihuacan_icono.png",
                    Imagen1 = "e_Travelteotihuacan_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Teotihuacan en Bici",
                    Descrip_Corta = "Recorridos",
                    Descrip_Larga = "Teotihuacan en Bicicleta... Esta es tu oportunidad para que visites las Pirámides de TEOTIHUACAN de una forma diferente. Es una nueva opción para que disfrutes de las maravillas y paisajes de la zona arqueológica más grande de México",
                    SitioWeb = "https://www.teotihuacanenbici.com.mx",
                    Direccion = "Av. San Francisco No.12, San Juan Teotihuacán, México.",
                    Horario = "10am – 6pm",
                    Telefono = "55 4980 6931",

                    Icono = "e_Teotihuacanenbici_icono.png",
                    Imagen1 = "e_Teotihuacanenbici_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Aventúrate en Teotihuacan",
                    Descrip_Corta = "Agencia Turística",
                    Descrip_Larga = "Ven a descubrir Teotihuacan en 4 ruedas & vive esta gran aventura.",
                    SitioWeb = "https://www.facebook.com/aventuraenteotihuacan/",
                    Direccion = "Avenida Pirámides, Barrio Purificación, San JuanTeotihuacan, México.",
                    Horario = "Siempre abierto",
                    Telefono = "55 7754 6922",

                    Icono = "e_Aventurateenteotihuacan_icono.png",
                    Imagen1 = "e_Aventurateenteotihuacan_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
 /*
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Explora Teotihuacán",
                    Descrip_Corta = "Agencia Turística",
                    Descrip_Larga = "Vuelos en globo, Tours en bici y Tours en cuatrimoto son las actividades que ofrecemos en la zona arqueológica mas importante de México",
                    SitioWeb = "http://www.explorateotihuacan.com.mx/index.html",
                    Direccion = "Calle 27 de septiembre No.8, San Martin de las Pirámides, México.",
                    Horario = "Siempre abierto",
                    Telefono = "55 7816 0271",
                    
                    Icono = "e_Explorateotihuacan_icono.png",
                    Imagen1 = "e_Explorateotihuacan_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },        
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Xplora Teotihuacán",
                    Descrip_Corta = "Agencia Turística",
                    Descrip_Larga = "Agencia turística en la zona arqueológica de Teotihuacán. Nos dedicamos a crear paquetes turísticos a su medida y viva la mejor experiencia de todas.",
                    SitioWeb = "https://www.facebook.com/teotixtremo/?ref=br_rs",
                    Direccion = "Sin Dirección",
                    Horario = "6am – 9pm",
                    Telefono = "55 4757 3519",
                   
                    Icono = "e_Xplorateotihuacan_icono.png",
                    Imagen1 = "e_Xplorateotihuacan_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },                         
                new LugarItem
                {
                    Categoria = "Entretenimiento",
                    Nombre = "Saber Correr",
                    Descrip_Corta = "Libro",
                    Descrip_Larga = "Correr es un deporte que recientemente se ha vuelto popular entre decenas de personas, sin embargo se ha detenido a pensar ¿qué significa saber correr?. De manera práctica y sencilla, este libro pondrá al alcance de su mano cada uno de los temas que lo ll",
                    SitioWeb = "http://www.etrillas.mx/catalogos.php?verBusqueda=saber%20correr",
                    Direccion = "Av. Río Churubusco 385 Pte. Col.General Pedro María Anaya, Del.Benito Juárez, Ciudad de México.",
                    Horario = "Siempre abierto",
                    Telefono = "5601  8582 y 56 88 4433",
                   
                    Icono = "e_sabercorrer_icono.png",
                    Imagen1 = "e_sabercorrer_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                 
*/
///////////////////////////////////////////////////////////////////HOTELES///////////////////////////////////////////
            new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Hotel villas Teotihuacán",
                    Descrip_Corta = "Hotel",
                    Descrip_Larga = "Villas Arqueológicas Teotihuacán se encuentra localizado al final de la Calzada de los Muertos, una antigua carretera en el centro del sitio arqueológico de Teotihuacán, una de las más importantes y bellas del mundo.",
                    SitioWeb = "https://www.facebook.com/VillasTeotihuacan/?ref=br_rs",
                    Direccion = "Periferico Sur, Zona Arqueologica,  México.",
                    Horario = "siempre abierto",
                    Telefono = "55 5836 9020",

                    Icono = "h_Villasteotihuacan_icono.png",
                    Imagen1 = "h_Villasteotihuacan_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Cabañas Kalli Nantli",
                    Descrip_Corta = "Cabañas",
                    Descrip_Larga = "Cabañas en renta en Teotihuacan, muy cerca de la Zona Arqueológica. Ideal para descansar, convivir y relajarse.",
                    SitioWeb = "https://www.facebook.com/kallinantli/",
                    Direccion = "Calle Tetitla #5, Bo. Purificación, San Juan Teotihuacán, México.",
                    Horario = "Siempre abierto",
                    Telefono = "55 2901 1383",

                    Icono = "h_kallinantli_icono.png",
                    Imagen1 = "h_kallinantli_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Teoticamp",
                    Descrip_Corta = "Hotel ecoturístico",
                    Descrip_Larga = "Complejo ecoturístico, consta de Hotel, Campamento, Restaurante, Salón de Usos Múltiples, Granja Interactiva, Equinoterapia, Alberca, Campo de Gotcha, tirolesa y ámplias áreas verdes.",
                    SitioWeb = "https://www.teoticamp.com/?fbclid=IwAR38a0KFNYDrAS0nF_hQ4kdt-eGo3FIudI54NGUD-fMqtiPnPj1PnmoWW3I",
                    Direccion = "Av. Ignacio Beteta 1A, Maquixco, 55843 Teotihuacán, Edo. Mex.",
                    Horario = "Siempre abierto",
                    Telefono = "594 956 2396",
                    Icono = "h_Teoticamp_icono.png",
                    Imagen1 = "h_Teoticamp_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Acocalli",
                    Descrip_Corta = "Hotel boutique",
                    Descrip_Larga = "Es un hotel boutique situado en el centro de Teotihuacán, dentro de él se percibe un ambiente particular, cálido e íntimo, relájate y acogedor, con una atmósfera que transmite la sensación de encontrarse en una casa, donde cada detalle esta cuidado con pa",
                    SitioWeb = "https://www.facebook.com/AcocalliTeotihuacan/",
                    Direccion = "Calle Reforma No. 8, Col. Centro, San Juan Teotihuacán Estado de México (1,18 km), 55800 Estado de México",
                    Horario = "Siempre abierto",
                    Telefono = "594 108 0828",

                    Icono = "h_Acocalli_icono.png",
                    Imagen1 = "h_Acocalli.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Villa Victoria Pirámides",
                    Descrip_Corta = "Hotel",
                    Descrip_Larga = "Conoce Teotihuacán desde las instalaciones de este grandioso hotel y su gran vista a la zona arqueológica, así quedaras convencido de que es tu mejor opción para hospedarte.",
                    SitioWeb = "https://www.facebook.com/VillaVictoriaPiramides/",
                    Direccion = "Niños Héroes, San Martín de las pirámides.",
                    Horario = "Siempre abierto",
                    Telefono = "5541761316 o 5529372951",

                    Icono = "h_villavictoria_icon.png",
                    Imagen1 = "h_villavictoria_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Hotel quinto sol",
                    Descrip_Corta = "Hotel",
                    Descrip_Larga = "A tan solo 2 minutos de las Pirámides de Teotihuacan, en donde el misticismo y la tranquilidad se mezclan en un solo concepto.",
                    SitioWeb = "https://www.facebook.com/HotelQuintoSolTeotihuacan/",
                    Direccion = "Av. Hidalgo no. 26 san juan teotihuacan (1,37 km), 55812 teotihuacán, edo. Mex.",
                    Horario = "Siempre abierto",
                    Telefono = "594 956 1881",

                    Icono = "h_Quintosol_icono.png",
                    Imagen1 = "h_Quintosol_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Hotel “Fer”",
                    Descrip_Corta = "Hotel",
                    Descrip_Larga = "Hospédate cerca de la zona arqueológica de Teotihuacán, a solo 400 m de la puerta 5",
                    SitioWeb = "https://www.facebook.com/HotelFERTeotihuacan/",
                    Direccion = "La Palma, San Juan Teotihuacán, México.",
                    Horario = "Siempre abierto",
                    Telefono = "55 1194 4281",

                    Icono = "h_Hotelfer_icono.png",
                    Imagen1 = "h_Hotelfer_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Hotel Telpochcalli",
                    Descrip_Corta = "Hotel",
                    Descrip_Larga = "El Hotel & Tezmacal Telpochcalli, se encuentra ubicado a 2 minutos de la puerta número 1 de la Zona Arqueológica de Teotihuacán, ideal para descansar y pasar un fin de semana en compañía de tu familia o amigos, ofrecemos WiFi gratuito.",
                    SitioWeb = "https://www.facebook.com/Hotel-Temazcal-Telpochcalli-Teotihuacan-M%C3%A9xico-722082994533199/",
                    Direccion = "Constitución No.8 San Sebastian Xolalpa, Teotihuacán, México.",
                    Horario = "Siempre abierto",
                    Telefono = "594 958 4247",

                    Icono = "h_Telpochcalli_icono.png",
                    Imagen1 = "h_Telpochcalli_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Hotel Quetzalcalli",
                    Descrip_Corta = "Hotel",
                    Descrip_Larga = "Hotel Quetzalcalli es un espacio diseñado especialmente para aquellas personas que buscan tranquilidad y acrecentar su conocimiento cultural en Teotihuacán",
                    SitioWeb = "https://www.facebook.com/hotelquetzalcalli/",
                    Direccion = "Constitución No.8,  San Sebastián Xolalpa, México.",
                    Horario = "Siempre abierto",
                    Telefono = "594 101 6037",

                    Icono = "h_HotelQuetzalcalli_icono.png",
                    Imagen1 = "h_HotelQuetzalcalli_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Posada Jatziri",
                    Descrip_Corta = "Hotel-Posada",
                    Descrip_Larga = "Hotel/ Posada con vista panorámica de la zona arqueológica de Teotihuacán, instalaciones comodas, seguras y a la vanguardia a su servicio.",
                    SitioWeb = "https://www.facebook.com/posadajatziri/",
                    Direccion = "Pino esquina durazno No.12, San Juan Teotihuacán, México.",
                    Horario = "Siempre abierto",
                    Telefono = "594 101 6202",

                    Icono = "h_HotelJatziri_icono.png",
                    Imagen1 = "h_HotelJatziri_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Vivanta",
                    Descrip_Corta = "Hotel Ecoturístico",
                    Descrip_Larga = "Parque Ecoturístico familiar con hotel, restaurante, alberca, áreas verdes, temazcal y salón de fiestas. Ideal para familias, grupos y convenciones.",
                    SitioWeb = "https://www.turisticavivanta.com/?fbclid=IwAR287XXrrcftgHRJ5SAbaOo5vetXyDuN5GXS7pHgBKRlyWqhZJPZrF5-NL4",
                    Direccion = "Prolongación Rosendo Arnaiz s/n, San Martín de las Pirámides, México.",
                    Horario = "9am – 5pm",
                    Telefono = "55 6744 8702",

                    Icono = "h_Vivanta_icono.png",
                    Imagen1 = "h_Vivanta_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Hotel Yaocalli",
                    Descrip_Corta = "Hotel",
                    Descrip_Larga = "Dentro de “Yaocalli” te invitamos a vivir una experiencia personalizada e inolvidable, brindándote un servicio de hospitalidad.",
                    SitioWeb = "https://www.facebook.com/Hotel-Yaocalli-414413498932716/?ref=timeline_chaining",
                    Direccion = "Calle Plaza 24 de Mayo No.9,  San Martín de las Pirámides, México.",
                    Horario = "Siempre abierto",
                    Telefono = "594 958 5736",

                    Icono = "h_Yaocalli_icono.png",
                    Imagen1 = "h_Yaocalli_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Hotel San Martin",
                    Descrip_Corta = "Hotel",
                    Descrip_Larga = "Una buena decisión a tu aventura, excelente ubicación, atención, higiene y la mejor tarifa en tu Hospedaje.",
                    SitioWeb = "https://www.facebook.com/hotelsanmartinoficial/?ref=timeline_chaining",
                    Direccion = "Plan San Luis No.25, San Martín de las Pirámides, México.",
                    Horario = "Siempre abierto",
                    Telefono = "594 958 2395",

                    Icono = "h_SanMartin_icono.png",
                    Imagen1 = "h_SanMartin_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Posada Marfael",
                    Descrip_Corta = "Hotel Posada",
                    Descrip_Larga = "Ofrecemos servicios de hospedaje para descansar y relajarse, en un ambiente de confort y tranquilidad.",
                    SitioWeb = "http://posadamarfaelteotihuacan.com/contacto/",
                    Direccion = "Calle San Felipe de Jesús s/n. Esquina Calle de Gante,San Martín de las Pirámides, México.",
                    Horario = "Siempre abierto",
                    Telefono = "594 958 5654",

                    Icono = "h_Marfael_icono.png",
                    Imagen1 = "h_Marfael_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Hotel villa meztli",
                    Descrip_Corta = "Hotel",
                    Descrip_Larga = "Ven a conocer las instalaciones de este grandioso hotel para que quedes convencido de que es tu mejor opción para hospedarte.",
                    SitioWeb = "https://www.facebook.com/Hotelvillameztli/",
                    Direccion = "Calle Gustavo Baz Mz 4 Lote 4, Teotihuacán, México.",
                    Horario = "Siempre abierto",
                    Telefono = "594 956 1582",

                    Icono = "h_villameztli_icono.png",
                    Imagen1 = "h_villameztli_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Hotel Teotihuacán",
                    Descrip_Corta = "Hotel",
                    Descrip_Larga = "Ven a conocer las instalaciones de este grandioso hotel para que quedes convencido de que es tu mejor opción para hospedarte.",
                    SitioWeb = "https://www.facebook.com/hotel.teotihuacan/",
                    Direccion = "Av. Pemex No.32, San Juan Teotihuacán, México.",
                    Horario = "Siempre abierto",
                    Telefono = "594 956 8588",

                    Icono = "h_hotelteotihuacan_icono.png",
                    Imagen1 = "h_hotelteotihuacan_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Hotel Primavera",
                    Descrip_Corta = "Hotel",
                    Descrip_Larga = "Ofrece un servicio de hospedaje sencillo con habitaciones totalmente renovadas de calidad e higiene.",
                    SitioWeb = "https://www.facebook.com/HotelPrimaveraTeotihuacan/",
                    Direccion = "Calle primavera no.8, San Martín de las Pirámides, México.",
                    Horario = "Siempre abierto",
                    Telefono = "594 958 2373",

                    Icono = "h_hotelprimavera_icono.png",
                    Imagen1 = "h_hotelprimavera_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
            new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Hotel Tonalli",
                    Descrip_Corta = "Hotel",
                    Descrip_Larga = "Ven a conocer las instalaciones de este grandioso hotel para que quedes convencido de que es tu mejor opción para hospedarte.",
                    SitioWeb = "https://www.facebook.com/hoteltonalli/?ref=br_rs",
                    Direccion = "Callejón jorge Jiménez Cantú, San Martín de las Pirámides, México.",
                    Horario = "Siempre abierto",
                    Telefono = "55 3017 2308",

                    Icono = "h_Hoteltonalli_icono.png",
                    Imagen1 = "h_Hoteltonalli_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Hotel Spa Metztli calli",
                    Descrip_Corta = "Hotel Spa",
                    Descrip_Larga = "Centro cultural Mexica, Spa Prehispanico, Temazcal, Biblioteca Prehispanica, Ceremonias Prehispanicas.",
                    SitioWeb = "https://www.facebook.com/spa.casadelaluna/",
                    Direccion = "Fresno No. 2, Cozotlan Norte,an Juan Teotihuacán, México.",
                    Horario = "Siempre abierto",
                    Telefono = "594 956 3877",

                    Icono = "h_Hotelmetztlicalli_icono.png",
                    Imagen1 = "h_Hotelmetztlicalli_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                new LugarItem
                {
                    Categoria = "Hoteles",
                    Nombre = "Temazcal “Oasis de Sanidad”",
                    Descrip_Corta = "Hotel Spa",
                    Descrip_Larga = "En Teotihuacán el lugar perfecto para armonizar su mente, cuerpo y espíritu. Combina el Temazcal Prehispánico y tecnología de punta para obtener salud y equilibrio; tratamientos específicos para mejorar su calidad de Vida.",
                    SitioWeb = "https://www.temazcaloasisdesanidad.com/?fbclid=IwAR3cTgq1Y4RMJLrBYl0jhaJIqfOncSdJ8NHt02Iu23wJ04KDFMAE9hHElCo",
                    Direccion = "Plan de Ayala #12, Esquina con Adolfo López Mateos, San Martín de las Pirámides.",
                    Horario = "9am – 6pm",
                    Telefono = "594 958 2345",

                    Icono = "e_Temazcaloasis_icono.png",
                    Imagen1 = "e_Temazcaloasis_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },
                ////////////////////////////////////////////////////////////////////
                ///

                new LugarItem
                {
                    Categoria = "Eventos",
                    Nombre = "7a Carrera de Teotihuacán",
                    Descrip_Corta = "Carrera",
                    Descrip_Larga = "3 rutas distintas (5km,10km y21km).",
                    SitioWeb = "",
                    Direccion = "Teotihuacán",
                    Horario = "Horario no disponible",
                    Telefono = "",
                    Icono = "ev_7carrera_icono.png",
                    Imagen1 = "ev_7carrera_1.jpg",
                    Imagen2 = "ev_7carrera_2.jpg",
                    Imagen3 = "ev_7carrera_3.jpg",
                    Imagen4 = "ev_7carrera_3.jpg"
                },
            /* new LugarItem
                {
                    Categoria = "Eventos",
                    Nombre = "Festival del pulque Teotihuacán",
                    Descrip_Corta = "Festival",
                    Descrip_Larga = "Si se pudiera hacer una comparación moderna sobre qué tan popular era el pulque, sería en contra de la cantidad de cerveza que hoy se consume en México.",
                    SitioWeb = "https://festival-del-pulque-teotihuacan.boletia.com/?fbclid=IwAR1B4l1SMZutl1cZ_eYM7bgC9uPWxjAEGx2Om9vcc5X5OaUUKa-qcj7yUjE",
                    Direccion = "Ctra. Federal México-Tulancingo Km. 28 (54,16 km) 55850 Teotihuacán",
                    Horario = "Horario no disponible",
                    Telefono = "5545170546",
                    Icono = "ev_festival_icono.png",
                    Imagen1 = "ev_festival_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                }, */
            new LugarItem
                {
                    Categoria = "Guias",
                    Nombre = "XIXO TOURS",
                    Descrip_Corta = "Agencia de viaje",
                    Descrip_Larga = "-Experiencia Vive Teotihuacán De Noche (Tour festivo de noche).\n\n-Experiencia Vocho Foodie (Tour gastronómico y de bebidas tradicionales).\n\n-Experiencia Centro del Universo  (Tour de día a Zona Arqueológica ó Barrios Teotihuacanos).\n\n-Experiencia Pueblo de Leyendas (Recorrido de Leyendas).\n\n-Experiencia Nocturna  (Entrada + Cena o Comida Bufet).\n\n-Vuelo en Globo.",
                    SitioWeb = "https://www.facebook.com/XixoTeotihuacan/",
                    Direccion = "Cerrada México 35, Evangelista, Teotihuacan, Edo.Mex",
                    Horario = "9am- 5pm",
                    Telefono = "5550733876",
                    Icono = "guias_xixo_1.jpeg",
                    Imagen1 = "guias_xixo_icon.png",
                    Imagen2 = "",
                    Imagen3 = ""    
                },

            new LugarItem
                {
                    Categoria = "Guias",
                    Nombre = "Kalawi tours",
                    Descrip_Corta = "Agencia de viaje",
                    Descrip_Larga = "Kalawi Tours es una agencia de viajes en Ciudad de México, especializada para viajeros individuales de habla hispana, con trato personalizado y de calidad. La empresa cuenta con una selección de excelentes operadores locales, para poner a su alcance una amplia gama de servicios como: hospedaje, transportación, visitas guiadas, renta de autos, eventos locales, shows, cenas típicas, entre otros, a destinos nacionales e internacionales.",
                    SitioWeb = "https://kalawitours.com/",
                    Direccion = "Baja California 368, Col. Hipódromo México, D.F. 06100",
                    Horario = "9am – 6pm",
                    Telefono = "5541761316 o 5529372951",
                    Icono = "Guias_Kalawi_icon.png",
                    Imagen1 = "Guias_Kalawi_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },

            new LugarItem
                {
                    Categoria = "Guias",
                    Nombre = "Os live",
                    Descrip_Corta = "Agencia de viaje",
                    Descrip_Larga = "Os Live es una agencia de viajes que ofrece planes para viajar personalizados e increíbles tours a destinos nacionales e internacionales",
                    SitioWeb = "http://oslive-viajes.econsolid.com/",
                    Direccion = "Calle Tonalá 345, Roma Sur, 06760 Ciudad de México",
                    Horario = "9am – 6pm",
                    Telefono = "5541761316 o 5529372951",
                    Icono = "Guias_oslive_icon.png",
                    Imagen1 = "Guias_oslive_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },

            new LugarItem
                {
                    Categoria = "Guias",
                    Nombre = "Xplora Teotihuacan",
                    Descrip_Corta = "Agencia de viaje",
                    Descrip_Larga = "Agencia turística en la zona arqueológica de Teotihuacán. Nos dedicamos a crear paquetes turísticos a su medida y viva la mejor experiencia de todas.",
                    SitioWeb = "https://www.facebook.com/teotixtremo/?ref=br_rs",
                    Direccion = "San Martin de las Piramides.",
                    Horario = "6am – 9pm",
                    Telefono = "5541761316 o 5529372951",
                    Icono = "Guias_xplora_icon.png",
                    Imagen1 = "Guias_xplora_1.jpg",
                    Imagen2 = "",
                    Imagen3 = ""
                },


            };

            return lugarItems;
        }
    }
}
