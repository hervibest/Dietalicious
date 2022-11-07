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
    /// Interaction logic for SearchRecipe.xaml
    /// </summary>
    public partial class SearchRecipe : Window
    {
        public SearchRecipe()
        {
            InitializeComponent();
        }

        private void Recipe_Click(object sender, RoutedEventArgs e)
        {

            Hide();
            Recipe_and_Ingredients recipe = new Recipe_and_Ingredients();
            recipe.Show();
        }
    }
}
