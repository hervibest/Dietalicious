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
using System.Net.Http;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Dietalicious
{
    /// <summary>
    /// Interaction logic for SearchRecipe.xaml
    /// </summary>
    public partial class SearchRecipe : Window
    {
        public DataTable dt;





        public class RootObject
        {

            public List<ThirdPartySuggester> Results { get; set; }
        }
        public class ThirdPartySuggester
        {
            public int id { get; set; }
            public string title { get; set; }
            public string image { get; set; }
            public string type { get; set; }
            public string jpg { get; set; }
            public int calories { get; set; }
            public string protein { get; set; }
            public string fat { get; set; }
            public string carbs { get; set; }
        }
        public SearchRecipe()
        {
            InitializeComponent();
            //GetAPIfromName();

        }
        private async void GetAPIfromName()
        {
            string Input = TbCalories.Text;
            var client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/complexSearch?query=pasta&cuisine=italian"),
                Headers =
               {
                    { "X-RapidAPI-Key", "f47554ac2fmsh3315b39d04d3f19p1a81eajsnf816b87369c7" },
                    { "X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com" },
               },
            };
            using (var response = await client.SendAsync(request))
            {

                response.EnsureSuccessStatusCode();
                dynamic body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);

                JObject o = JObject.Parse(body);

                JArray a = (JArray)o["results"];

                IList<ThirdPartySuggester> person = a.ToObject<IList<ThirdPartySuggester>>();

                
                dtGrid2.ItemsSource  = person;

                //RootObject obj = JsonConvert.DeserializeObject<RootObject>(body);
                //lbl.Content = obj;






            }



        }
        private async void GetAPI()
        {
            string Input = TbCalories.Text;
            string InputMin = TbCaloriesMin.Text;
            var client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/findByNutrients?limitLicense=false&maxCalories={Input}&minCalories={InputMin}"),
                Headers =
               {
                    { "X-RapidAPI-Key", "f47554ac2fmsh3315b39d04d3f19p1a81eajsnf816b87369c7" },
                    { "X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com" },
               },
            };
            using (var response = await client.SendAsync(request))
            {

                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
               
                var result = JsonConvert.DeserializeObject<List<ThirdPartySuggester>>(body);
                
                dtGrid2.ItemsSource = result;





            }



        }

        private void Recipe_Click(object sender, RoutedEventArgs e)
        {

            Hide();
          
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetAPI();
        }

        private void myDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if(row_selected != null)
            {
                MessageBox.Show("HEHEHE");
                
            }
            else
            {
                MessageBox.Show(row_selected["id"].ToString());
            }
        }

        private void dtGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            dynamic row_selected = gd.SelectedItem;
            if (row_selected != null)
            {
                string id = Convert.ToString(row_selected.id);
                Hide();
                Recipe_and_Ingredients recipe = new Recipe_and_Ingredients(id);

                recipe.Show();


            }
            else
            {
                MessageBox.Show(row_selected["id"].ToString());
            }
        }

        private void TbCalories_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

