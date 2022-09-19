    class Recipe
        //Class yang berisikan resep masakan
    {
        private int id;
        private string name;
        private string url_picture;
        private string password;
        private List<string> ingredient_list = new List<string>();
        private string method;
        private float calories;
        public Recipe(int ID, string Name, string urlPicture, string pass, List<string> ingredientList, string Method, float Cal)
        {
            id = ID;
            name = Name;
            url_picture = urlPicture;
            password = pass;
            ingredient_list = ingredientList;
            method = Method;
            calories = Cal;
        }
        public createRecipe()
        {
            
        }
        public editRecipe()
        {

        }
        public deleteRecipe()
        {

        }
        public searchRecipe(float calories)
        {

        }
    }