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

namespace OnlineRadio
{
    /// <summary>
    /// Логика взаимодействия для Player.xaml
    /// </summary>
    public partial class Player : Window
    {

        WindowsMediaPlayer wmPlayer = new WindowsMediaPlayer();
        string URL;

        public Player()
        {
            InitializeComponent();
            URL = @"http://nashe1.hostingradio.ru/rock-128.mp3";
        }

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.pause();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            wmPlayer.URL = URL;
            wmPlayer.controls.pause();
            wmPlayer.controls.play();
            player.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            wmPlayer.controls.stop();
            player.Stop();
        }
    }
}
