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
    /// Interaction logic for BMI.xaml
    /// </summary>
    public partial class BMI : Window
    {
        public BMI()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }
        private void Recipe_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Recipe_and_Ingredients recipe = new Recipe_and_Ingredients();
            recipe.Show();
        }
    }
}
