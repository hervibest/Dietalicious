class Ingredient
        //Class yang berisikan jenis bahan
    {
        private int id;
        private string name;
        private bool amountType;
        private int amount;
        private int calories;
        public Ingredient(int ID, bool amtType, string Name, string Cal, int amt)
   {
        id = ID;
        amountType = amtType;
        name= Name;
        calories= Cal;
        amount = amt;
   }
        public getCalories(){
            calories= amount*calories;
            return calories;
        }

    }