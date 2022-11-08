using Npgsql;
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
        private NpgsqlConnection conn;
        string connstring = "Host=mydatabase-instance.csbnsdtoskt5.ap-northeast-1.rds.amazonaws.com;Username=postgres;Password=informatika;Database=Dietalicious_database";
        public static NpgsqlCommand cmd;
        private string sql = null;
        public Settings()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            conn.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                conn.Open();
                sql = @"select * from st_update(:_user_name,:_name,:_email,:_new_password,:_bmi)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_user_name", tbUsn.Text);
                cmd.Parameters.AddWithValue("_name", tbName.Text);
                cmd.Parameters.AddWithValue("_email", tbEmail.Text);
                cmd.Parameters.AddWithValue("_password", tbPass.Password);
                cmd.Parameters.AddWithValue("_bmi", tbBMI.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users berhasil diupdate");
                    conn.Close();
                    Hide();
                    Home home = new Home();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Data tidak bisa disimpan, username tidak tersedia");
                    conn.Close();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Save data FAIL!!");
            }
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
