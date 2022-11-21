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
using Npgsql;

namespace Dietalicious
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        private NpgsqlConnection conn;
        string connstring = "Host=mydatabase-instance.csbnsdtoskt5.ap-northeast-1.rds.amazonaws.com;Username=postgres;Password=informatika;Database=Dietalicious_database";
        public static NpgsqlCommand cmd;
        private string sql = null;
        public SignUp()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            
         
        }

        private void Create(object sender, RoutedEventArgs e)
        {
            try {
                if (tbPassword.Password == tbConfirmPassword.Password)
                {
                    conn.Open();
                    sql = @"select * from st_create(:_user_name ,:_email,:_password)";
                    cmd = new NpgsqlCommand(sql, conn);
                   
                    cmd.Parameters.AddWithValue("_user_name", tbUsername.Text);
                    cmd.Parameters.AddWithValue("_email", tbEmail.Text);
                    cmd.Parameters.AddWithValue("_password", tbPassword.Password);
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data user berhasil diinputkan", "Success");
                        conn.Close();
               
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Password tidak sesuai!", "Warning");

                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Pembuatan akun tidak berhasil!");
            }
            Hide();
            MainWindow signUp = new MainWindow();
            signUp.Show();
        }
        private void Login(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow signUp = new MainWindow();
            signUp.Show();
        }
        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            pass_TxtBox.Text = tbPassword.Password;
            tbPassword.Visibility = Visibility.Collapsed;
            pass_TxtBox.Visibility = Visibility.Visible;
        }
        private void ShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            tbPassword.Password = pass_TxtBox.Text;
            pass_TxtBox.Visibility = Visibility.Collapsed;
            tbPassword.Visibility = Visibility.Visible;
        }
        private void ShowConfirmPassword_Checked(object sender, RoutedEventArgs e)
        {
            confirmpass_TxtBox.Text = tbConfirmPassword.Password;
            tbConfirmPassword.Visibility = Visibility.Collapsed;
            confirmpass_TxtBox.Visibility = Visibility.Visible;
        }
        private void ShowConfirmPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            tbConfirmPassword.Password = confirmpass_TxtBox.Text;
            confirmpass_TxtBox.Visibility = Visibility.Collapsed;
            tbConfirmPassword.Visibility = Visibility.Visible;
        }
    }
}

