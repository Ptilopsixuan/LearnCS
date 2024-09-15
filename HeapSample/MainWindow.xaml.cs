﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HeapSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Window> winList;

        private void btnIncrease_Click(object sender, RoutedEventArgs e)
        {
            winList = new List<Window>();
            for (int i = 0; i < 100000; i++)
            {
                Window win = new Window();
                winList.Add(win);
            }
        }

        private void btnRelease_Click(object sender, RoutedEventArgs e)
        {
            winList.Clear();
        }
    }
}