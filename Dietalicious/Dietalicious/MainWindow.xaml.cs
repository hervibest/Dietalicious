using System;
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

namespace Dietalicious
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

        private void Login(object sender, RoutedEventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }
        private void Register(object sender, RoutedEventArgs e)
        {
            Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
