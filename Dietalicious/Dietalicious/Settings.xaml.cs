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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }
        private void Favorite_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Favorites favorite = new Favorites();
            favorite.Show();
        }
    }
}
