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
using System.Windows.Shapes;
using Bossfighter;

namespace Bossfighter
{
    /// <summary>
    /// Interakční logika pro Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Help help =  new Help();

            if(txtbx.Text.Length != 0)
            {
                help.name = txtbx.Text;
            }
            else
            {
                help.name = "Player";
            }

            MainWindow main = new MainWindow();

            this.Visibility = Visibility.Hidden;
            main.Show();
        }
    }
}
