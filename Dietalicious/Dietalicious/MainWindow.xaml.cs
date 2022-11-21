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
using Npgsql;
using System.Data;


namespace Dietalicious
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NpgsqlConnection conn;
        string connstring = "Host=mydatabase-instance.csbnsdtoskt5.ap-northeast-1.rds.amazonaws.com;Username=postgres;Password=informatika;Database=Dietalicious_database";
        public static NpgsqlCommand cmd;
        private string sql = null; 
        public MainWindow()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            conn.Close();


        }

        private void Login(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from st_logins(:_user_name  ,:_password)";
                cmd = new NpgsqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("_user_name", tbUsername.Text);
                cmd.Parameters.AddWithValue("_password", tbPassword.Password);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data user berhasil ditemukan", "Login successful");
                    Global.UserName = new User(tbUsername.Text, tbPassword.Password);
                    MessageBox.Show($"Selamat datang {tbUsername.Text}!", "Welcome" );
                    conn.Close();

                    Hide();
                    Home home = new Home();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("User belum dibuat atau password salah", "Login failed");
                }
                    conn.Close();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Login error");
            }
            
        }
        private void Register(object sender, RoutedEventArgs e)
        {
            Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            passwordTxtBox.Text = tbPassword.Password;
            tbPassword.Visibility = Visibility.Collapsed;
            passwordTxtBox.Visibility = Visibility.Visible;
        }

        private void ShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            tbPassword.Password = passwordTxtBox.Text;
            passwordTxtBox.Visibility = Visibility.Collapsed;
            tbPassword.Visibility = Visibility.Visible;
        }
    }
}
