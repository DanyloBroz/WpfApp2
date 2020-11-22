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
using System.IO;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    
  {
        public Byte color;
        public MainWindow()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("color.txt");
            color = Convert.ToByte(sr.ReadLine());
            sr.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            StreamWriter sw = new StreamWriter("color.txt");
            sw.WriteLine(color);
            sw.Close();

        }
    }
}
