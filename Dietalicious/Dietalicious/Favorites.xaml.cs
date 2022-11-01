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

namespace Dietalicious
{
    /// <summary>
    /// Interaction logic for Favorites.xaml
    /// </summary>
    public partial class Favorites : Window
    {
        public Favorites()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lsFav_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
