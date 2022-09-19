class Ingredient
        //Class yang berisikan jenis bahan
    {
        private int id;
        private string name;
        private bool amountType;
        private int amount;
        private int calories;
        public Ingredient(string Name, string Cal, int amt)
   {
        name= Name;
        calories= Cal;
        amount = amt;
   }
        public getCalories(){
            calories= amount*calories;
            return calories;
        }

    }