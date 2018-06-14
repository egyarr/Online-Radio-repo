using System.Windows;
using WMPLib;

namespace OnlineRadio
{
    /// <summary>
    /// Логика взаимодействия для ListOfRadios.xaml
    /// </summary>
    public partial class ListOfRadios : Window
    {
        WindowsMediaPlayer wmPlayer = new WindowsMediaPlayer();
        Player pl;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        string n = "Now playing: ", ROCKurl, CHOCOurl, EUROurl, RETROurl, DORurl, RECurl, BUSurl, AUTOurl;
        
        public ListOfRadios()
        {
            InitializeComponent();
            ROCKurl = @"http://nashe1.hostingradio.ru/rock-128.mp3";
            CHOCOurl = @"http://choco.hostingradio.ru:10010/fm";
            EUROurl = @"http://ep256.hostingradio.ru:8052/europaplus256.mp3";
            RETROurl = @"http://retroserver.streamr.ru:8043/retro256.mp3";
            DORurl = @"http://dorognoe.hostingradio.ru:8000/dorognoe";
            RECurl = @"http://air2.radiorecord.ru:805/rr_64";
            BUSurl = @"https://bfm.hostingradio.ru:9075/fm";
            AUTOurl = @"http://ic2.101.ru:8000/v3_1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("YOU SHOULD HAVE A STABLE INTERNET CONECTION TO USE THIS APP!!!. In this window you can choose which radio do you want to listen. " +
                "Moreover, you can listen to your own internet radio stream by using CUSTOM URL button. " +
                "There is a stop button at the bottom of the window. You will stop the music by pressing it. " +
                "Enjoy yourself!");
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
        private void ToPlayer(object sender, RoutedEventArgs e)
        {
            pl = new Player();
            pl.Show();
            Window.GetWindow(this).Close();
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
        private void Record(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.stop();
            wmPlayer.URL = RECurl;
            wmPlayer.controls.play();
            player.Play();
            Now_playing.Content = n + "Radio Record";
            img.Visibility = Visibility.Visible;
        }
        private void Business(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.stop();
            wmPlayer.URL = BUSurl;
            wmPlayer.controls.play();
            player.Play();
            Now_playing.Content = n + "Business FM";
            img.Visibility = Visibility.Visible;
        }
        private void Auto(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.stop();
            wmPlayer.URL = AUTOurl;
            wmPlayer.controls.play();
            player.Play();
            Now_playing.Content = n + "Auto Radio";
            img.Visibility = Visibility.Visible;
        }

    }
}
