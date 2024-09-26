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

namespace dnl2k07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            hatter.MouseUp += Hatter_MouseUp;
        }

        private void Hatter_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Random r = new Random();
            int randomSzam = r.Next(1, 7);
            szam.Text = randomSzam.ToString();
        }
    }
}