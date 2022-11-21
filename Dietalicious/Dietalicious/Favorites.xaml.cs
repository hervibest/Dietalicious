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
using System.Data;

namespace Dietalicious
{
    /// <summary>
    /// Interaction logic for Favorites.xaml
    /// </summary>
    public partial class Favorites : Window
    {
        private NpgsqlConnection conn;
        string connstring = "Host=mydatabase-instance.csbnsdtoskt5.ap-northeast-1.rds.amazonaws.com;Username=postgres;Password=informatika;Database=Dietalicious_database";
        public static NpgsqlCommand cmd;
        public DataTable dt;
        private string sql = null;
        public Favorites()
        {
            InitializeComponent();
            API();
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
        private void API()
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            sql = @"select * from st_read_list(:_username)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_username", Global.UserName.getUserName());
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgvData.ItemsSource = dt.DefaultView;


        conn.Close();
        }

        private void lsFav_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
