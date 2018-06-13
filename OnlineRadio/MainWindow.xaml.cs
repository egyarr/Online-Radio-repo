﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OnlineRadio
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ListOfRadios ListOfRadios;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListOfRadios = new ListOfRadios();
            ListOfRadios.Show();
            Window.GetWindow(this).Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("This app was designed by Kokhanchuk Egor (BI172), " +
                "Danila Schepelev (BI172) and Alexander Klimov (BI172). All links were copied from: https://vk.com/topic-103116043_34671966.");
        }
    }
}
