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

namespace OnlineRadio
{
    /// <summary>
    /// Логика взаимодействия для ListOfRadios.xaml
    /// </summary>
    public partial class ListOfRadios : Window
    {
        public ListOfRadios()
        {
            InitializeComponent();
        }
         
        Player pl;
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pl = new Player();
            pl.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pl = new Player();
            pl.Show();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\\..\\Music\\Valve.wav");
            player.Play();
        }
    }
}
