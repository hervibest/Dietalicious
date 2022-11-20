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
using System.Diagnostics;
using RestSharp;
using Newtonsoft.Json;
namespace Dietalicious
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
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
        public Home()
        {
            InitializeComponent();
            //GetAPI();
            tbUsn.Text = Global.UserName.getUserName();
        }
        private  async void  GetAPI()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/findByNutrients?limitLicense=false&maxFluoride=50&maxVitaminB5=50&maxVitaminB3=50&maxIodine=50&minCarbs=0&maxCalories=250&minAlcohol=0&maxCopper=50&maxCholine=50&maxVitaminB6=50&minIron=0&maxManganese=50&minSodium=0&minSugar=0&maxFat=20&minCholine=0&maxVitaminC=50&maxVitaminB2=50&minVitaminB12=0&maxFolicAcid=50&minZinc=0&offset=0&maxProtein=100&minCalories=0&minCaffeine=0&minVitaminD=0&maxVitaminE=50&minVitaminB2=0&minFiber=0&minFolate=0&minManganese=0&maxPotassium=50&maxSugar=50&maxCaffeine=50&maxCholesterol=50&maxSaturatedFat=50&minVitaminB3=0&maxFiber=50&maxPhosphorus=50&minPotassium=0&maxSelenium=50&maxCarbs=100&minCalcium=0&minCholesterol=0&minFluoride=0&maxVitaminD=50&maxVitaminB12=50&minIodine=0&maxZinc=50&minSaturatedFat=0&minVitaminB1=0&maxFolate=50&minFolicAcid=0&maxMagnesium=50&minVitaminK=0&maxSodium=50&maxAlcohol=50&maxCalcium=50&maxVitaminA=50&maxVitaminK=50&minVitaminB5=0&maxIron=50&minCopper=0&maxVitaminB1=50&number=10&minVitaminA=0&minPhosphorus=0&minVitaminB6=0&minFat=5&minVitaminE=0"),
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
            
                //var list = JsonConvert.DeserializeObject<List<ThirdPartySuggester>>(body);
                //lblTest.Content = body;



            }
            //var client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/findByNutrients?limitLicense=false&minProtein=0&minVitaminC=0&minSelenium=0&maxFluoride=50&maxVitaminB5=50&maxVitaminB3=50&maxIodine=50&minCarbs=0&maxCalories=250&minAlcohol=0&maxCopper=50&maxCholine=50&maxVitaminB6=50&minIron=0&maxManganese=50&minSodium=0&minSugar=0&maxFat=20&minCholine=0&maxVitaminC=50&maxVitaminB2=50&minVitaminB12=0&maxFolicAcid=50&minZinc=0&offset=0&maxProtein=100&minCalories=0&minCaffeine=0&minVitaminD=0&maxVitaminE=50&minVitaminB2=0&minFiber=0&minFolate=0&minManganese=0&maxPotassium=50&maxSugar=50&maxCaffeine=50&maxCholesterol=50&maxSaturatedFat=50&minVitaminB3=0&maxFiber=50&maxPhosphorus=50&minPotassium=0&maxSelenium=50&maxCarbs=100&minCalcium=0&minCholesterol=0&minFluoride=0&maxVitaminD=50&maxVitaminB12=50&minIodine=0&maxZinc=50&minSaturatedFat=0&minVitaminB1=0&maxFolate=50&minFolicAcid=0&maxMagnesium=50&minVitaminK=0&maxSodium=50&maxAlcohol=50&maxCalcium=50&maxVitaminA=50&maxVitaminK=50&minVitaminB5=0&maxIron=50&minCopper=0&maxVitaminB1=50&number=10&minVitaminA=0&minPhosphorus=0&minVitaminB6=0&minFat=5&minVitaminE=0");
            //var request = new RestRequest(Method.GET);
            //request.AddHeader("X-RapidAPI-Key", "f47554ac2fmsh3315b39d04d3f19p1a81eajsnf816b87369c7");
            //request.AddHeader("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");

            //IRestResponse response = client.Execute<List<ThirdPartySuggester>>(request);
            
            //lblTest.Content = response;


        }
        private void Recipe_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            SearchRecipe recipe = new SearchRecipe();
            recipe.Show();
        }
        private void BMI_Click(object sender, RoutedEventArgs e)
        {
            string Username = Global.UserName.getUserName();
            Hide();
            BMI bmi = new BMI();
            bmi.Show();
        }
        private void Account_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Settings settings = new Settings();
            settings.Show();
        }

        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            //Global.UserName.deleteUserName();
            MainWindow signUp = new MainWindow();
            signUp.Show();
        }
    }
}
