using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TextAdventureBuilderGui;

namespace TextAdventureBuilder
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        Handler handler;

        public GameWindow()
        {
            InitializeComponent();
            handler = new Handler(this);
        }

        private void NorthButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SouthButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EastButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WestButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void InventoryButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            handler.SearchRoom();
        }
    }
}
