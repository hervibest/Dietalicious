using Npgsql;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        private NpgsqlConnection conn;
        string connstring = "Host=mydatabase-instance.csbnsdtoskt5.ap-northeast-1.rds.amazonaws.com;Username=postgres;Password=informatika;Database=Dietalicious_database";
        public static NpgsqlCommand cmd;
        public static NpgsqlCommand cmd2;
        private string sql = null;
        public double Calories;
        public BMI()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
        }

        private double ConvertToDouble(string value)
        {
            double number;
            Double.TryParse(value, out number);
            return number;
        }

        private double CalculateBMI(double height, double weight)
        {
            double bmi = weight / (Math.Pow((height * 0.01), 2));

            return bmi;
        }

        private double CalculateCal(double height, double weight, int age)
        {
            double cal = (10 * (weight)) + (6.25 * (height)) - (5 * age);
            if (rbtnFem.IsChecked == true)
            {
                cal = (cal - 161) * 1.2;
            }
            else
                cal = (cal + 5) * 1.2;
            return cal/3;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double height = ConvertToDouble(tbHeight.Text), weight = ConvertToDouble(tbWeight.Text);
                int age = int.Parse(tbAge.Text);
                double bmi = Math.Round(CalculateBMI(height, weight), 2);
                double cal = Math.Round(CalculateCal(height, weight, age), 2);

                tbBMI.Text = bmi.ToString();
                tbCal.Text = cal.ToString();
                Calories = cal;


                conn.Open();
               

                sql = @"select * from st_calcbmi(:_height,:_weight,:_sex)";
                cmd2 = new NpgsqlCommand(sql, conn);
                cmd2.Parameters.AddWithValue("_height", height);
                cmd2.Parameters.AddWithValue("_weight", weight);
                cmd2.Parameters.AddWithValue("_sex", true); 
                if ((int)cmd2.ExecuteScalar() == 1)
                {
                    MessageBox.Show("BMI berhasil ditambahkan", "Success");


                    conn.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal pada saat perhitungan!");
            }
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
            SearchRecipe recipe = new SearchRecipe(Calories);
            recipe.Show();
        }
    }
}
