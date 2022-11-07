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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Recipe_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            SearchRecipe recipe = new SearchRecipe();
            recipe.Show();
        }
        private void BMI_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            BMI bmi = new BMI();
            bmi.Show();
        }
        private void Account_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Settings settings = new Settings();
            settings.Show();
        }

        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow signUp = new MainWindow();
            signUp.Show();
        }
    }
}
