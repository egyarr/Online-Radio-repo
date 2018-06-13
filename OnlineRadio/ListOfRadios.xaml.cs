using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WMPLib;
using WpfAnimatedGif;

namespace OnlineRadio
{
    /// <summary>
    /// Логика взаимодействия для ListOfRadios.xaml
    /// </summary>
    public partial class ListOfRadios : Window
    {

        WindowsMediaPlayer wmPlayer = new WindowsMediaPlayer();
        string ROCKurl, CHOCOurl, EUROurl, RETROurl, DORurl;
        string n = "Now playing: ";
        

        public ListOfRadios()
        {
            InitializeComponent();
            ROCKurl = @"http://nashe1.hostingradio.ru/rock-128.mp3";
            CHOCOurl = @"http://choco.hostingradio.ru:10010/fm";
            EUROurl = @"http://ep256.hostingradio.ru:8052/europaplus256.mp3";
            RETROurl = @"http://retroserver.streamr.ru:8043/retro256.mp3";
            DORurl = @"http://dorognoe.hostingradio.ru:8000/dorognoe";
        }
         
        Player pl;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    pl = new Player();
        //    pl.Show();
        //}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\\..\\Music\\Valve.wav");
            if (pl != null)
            {                
                player.Play();
            }

            if (pl == null)
                pl = new Player();
            
            pl.Show();           
            player.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Here will be some text");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.stop();
            wmPlayer.URL = ROCKurl;
            wmPlayer.controls.play();
            player.Play();
            Now_playing.Content = n + "Rock Radio";
            img.Visibility = Visibility.Visible;
        }

        private void Stop_Button(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.stop();
            Now_playing.Content = "Nothing is playing now";
            img.Visibility = Visibility.Hidden;
        }

        private void Chocolate(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.stop();
            wmPlayer.URL = CHOCOurl;
            wmPlayer.controls.play();
            player.Play();
            Now_playing.Content = n+"Radio Chocolate";
            img.Visibility = Visibility.Visible;
        }
        private void Europa_Plus(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.stop();
            wmPlayer.URL = EUROurl;
            wmPlayer.controls.play();
            player.Play();
            Now_playing.Content = n + "Europa Plus";
            img.Visibility = Visibility.Visible;
        }
        private void Retro(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.stop();
            wmPlayer.URL = RETROurl;
            wmPlayer.controls.play();
            player.Play();
            Now_playing.Content = n + "Retro FM";
            img.Visibility = Visibility.Visible;
        }
        private void Doroznoe(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.stop();
            wmPlayer.URL = DORurl;
            wmPlayer.controls.play();
            player.Play();
            Now_playing.Content = n + "Doroznoe Radio";
            img.Visibility = Visibility.Visible;
        }


    }
}
