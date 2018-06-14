using System.Windows;
using WMPLib;

namespace OnlineRadio
{
    /// <summary>
    /// Логика взаимодействия для Player.xaml
    /// </summary>
    public partial class Player : Window
    {
        ListOfRadios l;
        WindowsMediaPlayer wmPlayer = new WindowsMediaPlayer();
        string URL;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Player()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.pause();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            URL = textbox_url.Text;
            wmPlayer.URL = URL;
            wmPlayer.controls.pause();
            wmPlayer.controls.play();
            player.Play();
            img.Visibility = Visibility.Visible;
            img2.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.stop();
            player.Stop();
            img.Visibility = Visibility.Hidden;
            img2.Visibility = Visibility.Hidden;
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            l = new ListOfRadios();
            l.Show();
            Window.GetWindow(this).Close();
        }
    }
}
