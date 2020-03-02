using ExplorAppTeo.Models;
using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExplorAppTeo.ViewModels;
using MediaManager;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;

namespace ExplorAppTeo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class GuiaPage : ContentPage
    {
        List<AudioMenuItem> audioItems;
        private static System.Timers.Timer aTimer;
        FileImageSource playImage;
        FileImageSource pauseImage;

        GuiaViewModel guiaView = new GuiaViewModel();
        string Puerta;

        public GuiaPage()
        {
            InitializeComponent();

            audioItems = new List<AudioMenuItem>
            {
                new AudioMenuItem { Id = 0, Title = "1. " + AudioItem.Name[0], Duration = AudioItem.Duration[0], URL = AudioItem.URL[0], Seconds = AudioItem.Seconds[0]},
                new AudioMenuItem { Id = 1, Title = "2. " + AudioItem.Name[6], Duration = AudioItem.Duration[6], URL = AudioItem.URL[6], Seconds = AudioItem.Seconds[6] },
                new AudioMenuItem { Id = 2, Title = "3. " + AudioItem.Name[9], Duration = AudioItem.Duration[9], URL = AudioItem.URL[9], Seconds = AudioItem.Seconds[9] },
                new AudioMenuItem { Id = 3, Title = "4. " + AudioItem.Name[11], Duration = AudioItem.Duration[11], URL = AudioItem.URL[11], Seconds = AudioItem.Seconds[11] },
                new AudioMenuItem { Id = 4, Title = "5. " + AudioItem.Name[5], Duration = AudioItem.Duration[5], URL = AudioItem.URL[5], Seconds = AudioItem.Seconds[5] },
                new AudioMenuItem { Id = 5, Title = "6. " + AudioItem.Name[3], Duration = AudioItem.Duration[3], URL = AudioItem.URL[3], Seconds = AudioItem.Seconds[3] },
                new AudioMenuItem { Id = 6, Title = "7. " + AudioItem.Name[2], Duration = AudioItem.Duration[2], URL = AudioItem.URL[2], Seconds = AudioItem.Seconds[2] },
                new AudioMenuItem { Id = 7, Title = "8. " + AudioItem.Name[1], Duration = AudioItem.Duration[1], URL = AudioItem.URL[1], Seconds = AudioItem.Seconds[1] },
                new AudioMenuItem { Id = 8, Title = "9. " + AudioItem.Name[4], Duration = AudioItem.Duration[4], URL = AudioItem.URL[4], Seconds = AudioItem.Seconds[4] },
                new AudioMenuItem { Id = 9, Title = "10. " + AudioItem.Name[12], Duration = AudioItem.Duration[12], URL = AudioItem.URL[12], Seconds = AudioItem.Seconds[12] },
                new AudioMenuItem { Id = 10, Title= "11. " + AudioItem.Name[7], Duration = AudioItem.Duration[7], URL = AudioItem.URL[7], Seconds = AudioItem.Seconds[7] },
                new AudioMenuItem { Id = 11, Title = "12. " + AudioItem.Name[15], Duration = AudioItem.Duration[15], URL = AudioItem.URL[15], Seconds = AudioItem.Seconds[15] },
                new AudioMenuItem { Id = 12, Title = "13. " + AudioItem.Name[13], Duration = AudioItem.Duration[13], URL = AudioItem.URL[13], Seconds = AudioItem.Seconds[13] },
                new AudioMenuItem { Id = 13, Title = "14. " + AudioItem.Name[14], Duration = AudioItem.Duration[14], URL = AudioItem.URL[14], Seconds = AudioItem.Seconds[14] },
                new AudioMenuItem { Id = 14, Title = "15. " + AudioItem.Name[10], Duration = AudioItem.Duration[10], URL = AudioItem.URL[10], Seconds = AudioItem.Seconds[10] },
                new AudioMenuItem { Id = 15, Title = "16. " + AudioItem.Name[17], Duration = AudioItem.Duration[17], URL = AudioItem.URL[17], Seconds = AudioItem.Seconds[17] },
                new AudioMenuItem { Id = 16, Title = "17. " + AudioItem.Name[8], Duration = AudioItem.Duration[8], URL = AudioItem.URL[8], Seconds = AudioItem.Seconds[8] },
                new AudioMenuItem { Id = 17, Title = "18. " + AudioItem.Name[16], Duration = AudioItem.Duration[16], URL = AudioItem.URL[16], Seconds = AudioItem.Seconds[16] },
            };

            AudiosListView.ItemsSource = audioItems;

            SetTimer();
        }

        public GuiaPage(string puertaId)
        {
            InitializeComponent();

            AudioList listaAudios = new AudioList();
            Puerta = puertaId;

            switch(puertaId)
            {
                case "Puerta1":
                    Title = "Guía - Puerta 1";
                    AudiosListView.ItemsSource = listaAudios.List(1);
                    Ruta.Source = "Ruta1.png";
                    break;
                case "Puerta2":
                    Title = "Guía - Puerta 2";
                    AudiosListView.ItemsSource = listaAudios.List(2);
                    Ruta.Source = "Ruta2.png";
                    break;
                case "Puerta3":
                    Title = "Guía - Puerta 3";
                    AudiosListView.ItemsSource = listaAudios.List(3);
                    Ruta.Source = "Ruta3.png";
                    break;
                case "Puerta4":
                    Title = "Guía - Puerta 4";
                    AudiosListView.ItemsSource = listaAudios.List(4);
                    Ruta.Source = "Ruta4.png";
                    break;
                case "Puerta5":
                    Title = "Guía - Puerta 5";
                    AudiosListView.ItemsSource = listaAudios.List(5);
                    Ruta.Source = "Ruta5.png";
                    break;
            }

            pauseImage = new FileImageSource { File = "icono_pausa.png" };
            playImage = new FileImageSource { File = "icono_play.png" };

            SetTimer();
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();

            //GuiaHelpers.GridWidth = MapLayout.Width;
            //GuiaHelpers.GridHeight = MapLayout.Height;

            GuiaHelpers.GridWidth = GuiaLayout.Width;
            GuiaHelpers.GridHeight = GuiaLayout.Height;

            guiaView.ImageTranslate(Ruta, Puerta, 0, 1);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            CrossMediaManager.Current.Stop();
        }

        async private void AudiosListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            if ((CrossMediaManager.Current.State == MediaManager.Playback.MediaPlayerState.Playing) || (CrossMediaManager.Current.State == MediaManager.Playback.MediaPlayerState.Paused))
            //if (CrossMediaManager.Current.IsPlaying())
            {
                await CrossMediaManager.Current.Stop();
                aTimer.Enabled = false;
            }

            AudioLabel.Text = ((AudioMenuItem)e.SelectedItem).Title;
            string url = ((AudioMenuItem)e.SelectedItem).URL;
            AudioSlider.Maximum = ((AudioMenuItem)e.SelectedItem).Seconds;
            guiaView.ImageTranslate(Ruta, Puerta, (int)((AudioMenuItem)e.SelectedItem).Id, 5);

            CrossMediaManager.Current.StateChanged += Current_StateChanged;
            _ = await CrossMediaManager.Current.Play(url);

            GuiaLayout.IsVisible = true;
            AudiosScrollView.IsVisible = false;
            MapLayout.IsVisible = false;

            AudioSlider.Value = 0;
        }

        private void Guia_Clicked(object sender, EventArgs e)
        {
            GuiaLayout.IsVisible = true;
            AudiosScrollView.IsVisible = false;
            MapLayout.IsVisible = false;
        }

        private void Track_Clicked(object sender, EventArgs e)
        {
            GuiaLayout.IsVisible = false;
            AudiosScrollView.IsVisible = true;
            MapLayout.IsVisible = false;
        }

        private void Map_Clicked(object sender, EventArgs e)
        {
            GuiaLayout.IsVisible = false;
            AudiosScrollView.IsVisible = false;
            MapLayout.IsVisible = true;
        }

        private async void Camera_Clicked(object sender, EventArgs e)
        {
            var isInitialize = await CrossMedia.Current.Initialize();

            if(!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.IsSupported || !isInitialize)
            {
                await DisplayAlert("Error", "La cámara no se encuentra disponible", "OK");
                return;
            }

            var cameraStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
            var storageStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);

            if (cameraStatus != PermissionStatus.Granted || storageStatus != PermissionStatus.Granted)
            {
                var cameraResult = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Camera);
                var storageResult = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Storage);

                cameraStatus = cameraResult[Permission.Camera];
                storageStatus = storageResult[Permission.Storage];
            }

            if (cameraStatus == PermissionStatus.Granted && storageStatus == PermissionStatus.Granted)
            {
                var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    Directory = "ExplorApp",
                    Name = "explorateotihuacan",
                    SaveToAlbum = true,
                    DefaultCamera = CameraDevice.Rear
                });

                if (file == null)
                {
                    return;
                }

                await DisplayAlert("Fotografía guardada", file.AlbumPath, "OK");
            }
            else
            {
                await DisplayAlert("Permiso de Cámara denegado", "No se pueden tomar fotografías", "OK");
            }

        }

        async private void ButtonPlay_Clicked(object sender, EventArgs e)
        {
            if (CrossMediaManager.Current.IsPlaying())
            {
                await CrossMediaManager.Current.Pause();
                aTimer.Enabled = false;
                PlayButton.Image = playImage;
            }
            else if(CrossMediaManager.Current.State == MediaManager.Playback.MediaPlayerState.Paused)
            {
                await CrossMediaManager.Current.Play();
                aTimer.Enabled = true;
                PlayButton.Image = pauseImage;
            }
        }

        async private void ButtonRwd_Clicked(object sender, EventArgs e)
        {
            if (CrossMediaManager.Current.IsPlaying())
            {
                TimeSpan timeSpan = new TimeSpan(0, 0, 10);
                CrossMediaManager.Current.StepSize = timeSpan;
                await CrossMediaManager.Current.StepBackward();
                AudioSlider.Value -= 10;
            }
        }

        async private void ButtonFwd_Clicked(object sender, EventArgs e)
        {
            if (CrossMediaManager.Current.IsPlaying())
            {
                TimeSpan timeSpan = new TimeSpan(0, 0, 10);
                CrossMediaManager.Current.StepSize = timeSpan;
                await CrossMediaManager.Current.StepForward();
                AudioSlider.Value += 10;
            }
        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = false;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            AudioSlider.Value += 1;
        }

        private void Current_StateChanged(object sender, MediaManager.Playback.StateChangedEventArgs e)
        {
            switch(CrossMediaManager.Current.State)
            {
                case MediaManager.Playback.MediaPlayerState.Playing:
                    aTimer.Enabled = true;
                    PlayButton.Image = pauseImage;
                    break;

                case MediaManager.Playback.MediaPlayerState.Stopped:
                    aTimer.Enabled = false;
                    PlayButton.Image = playImage;
                    break;
            }
            //if (CrossMediaManager.Current.State == MediaManager.Playback.MediaPlayerState.Playing)
            //{
            //    aTimer.Enabled = true;
            //    PlayButton.Image = pauseImage;
            //}
            
            //if (CrossMediaManager.Current.State == MediaManager.Playback.MediaPlayerState.Stopped)
            //{
            //    aTimer.Enabled = false;
            //    PlayButton.Image = playImage;
            //}
        }
    }
}