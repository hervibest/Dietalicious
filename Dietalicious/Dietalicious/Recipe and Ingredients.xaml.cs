﻿using System;
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

using Newtonsoft.Json.Linq;
using System.Text.Json;
namespace Dietalicious
{
    /// <summary>
    /// Interaction logic for Recipe_and_Ingredients.xaml
    /// </summary>
    public partial class Recipe_and_Ingredients : Window
    {
        public class Ingredients
        {
           
            public string aisle { get; set; }
            public string name { get; set; }
            public int amount { get; set; }
            public string unit { get; set; }
            

        }
        public class RecipeID
        {
            public string instructions { get; set; }
            public string title { get; set; }
            public string image { get; set; }
            public int readyInMinutes { get; set; }
            public string type { get; set; }
            public string sourceUrl { get; set; }
            public int calories { get; set; }
            public string protein { get; set; }
            public string fat { get; set; }
            public string carbs { get; set; }
            
        }
        public Recipe_and_Ingredients(string ID)
        {
            InitializeComponent();
            GetAPI(ID);
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }
        private async void GetAPI(string ID)
        {
            string Input = ID;
            var client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/{ID}/information"),
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
                RecipeID recipe = JsonSerializer.Deserialize<RecipeID>(body);
                Console.WriteLine(body);
                //lblResep.Content = recipe.title;
                TxtBoxResep.Text = recipe.title;
                TxtBoxData.Text = recipe.instructions;
                TxtBoxWaktu.Text = " Time: " + recipe.readyInMinutes.ToString() + " Minutes";
                myImage.Source = new BitmapImage(new Uri($@"{recipe.image}", UriKind.RelativeOrAbsolute));

                dynamic ingredients = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);

                JObject o = JObject.Parse(ingredients);

                JArray a = (JArray)o["extendedIngredients"];

                IList<Ingredients> person = a.ToObject<IList<Ingredients>>();
                MessageBox.Show(body);
                
                dtGrid2.ItemsSource = person;




            }

        }
    }
}
