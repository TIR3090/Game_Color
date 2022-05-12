using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace minotl
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Bt_start.CornerRadius = 100;
       }
        public async void start(object sender,EventArgs e)
        {
            Bt_start.ScaleTo(0.9,125);
            await Bt_start.TranslateTo(0,-5,125);
            Bt_start.ScaleTo(1, 125);
            await Bt_start.TranslateTo(0, 5, 125);

            #region Проигрывание звука при нажатии на кнопку
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("test.mp3");
            player.Play();
            #endregion

            await Navigation.PushAsync(new Game());
            
        }


    }
}
