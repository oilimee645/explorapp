using ExplorAppTeo.Models;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace ExplorAppTeo.ViewModels
{
    public class GuiaViewModel : BaseViewModel
    {
        public GuiaViewModel()
        {
            Title = "Guía";
        }

        public async void ImageTranslate(Image imagen, string puerta, int posicion, uint seconds)
        {
            switch (puerta)
            {
                case "Puerta1":
                    await imagen.TranslateTo(RutaList.Ruta1[posicion].x + (GuiaHelpers.GridWidth / 2), RutaList.Ruta1[posicion].y + (GuiaHelpers.GridHeight / 2), seconds*1000);
                    break;

                case "Puerta2":
                    await imagen.TranslateTo(RutaList.Ruta2[posicion].x + (GuiaHelpers.GridWidth / 2), RutaList.Ruta2[posicion].y + (GuiaHelpers.GridHeight / 2), seconds * 1000);
                    break;

                case "Puerta3":
                    await imagen.TranslateTo(RutaList.Ruta3[posicion].x + (GuiaHelpers.GridWidth / 2), RutaList.Ruta3[posicion].y + (GuiaHelpers.GridHeight / 2), seconds * 1000);
                    break;

                case "Puerta4":
                    await imagen.TranslateTo(RutaList.Ruta4[posicion].x + (GuiaHelpers.GridWidth / 2), RutaList.Ruta4[posicion].y + (GuiaHelpers.GridHeight / 2), seconds * 1000);
                    break;

                case "Puerta5":
                    await imagen.TranslateTo(RutaList.Ruta5[posicion].x + (GuiaHelpers.GridWidth / 2), RutaList.Ruta5[posicion].y + (GuiaHelpers.GridHeight / 2), seconds * 1000);
                    break;
            }
        }
    }
}
