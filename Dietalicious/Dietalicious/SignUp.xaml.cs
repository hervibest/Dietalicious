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
                        MessageBox.Show("Data Users berhasil diinputkan", "Well Done!");
                        conn.Close();
               
                    }
                    MessageBox.Show("password sama");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Password tidak sama");

                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert FAIL!!");
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

