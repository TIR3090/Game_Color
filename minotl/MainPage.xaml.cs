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
        }
        public async void start(object sender,EventArgs e)
        {

            #region Проигрывание звука при нажатии на кнопку
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("test.mp3");
            player.Play();
            #endregion

            await Navigation.PushAsync(new Game());
            
        }


    }
}
