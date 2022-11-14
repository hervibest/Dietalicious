using System.Collections.Generic;
using System;
namespace Dietalicious
{
    public class Ingredient
    //Class yang berisikan jenis bahan
    {

        private int id;
        private string name;
        private bool amountType;
        private int amount;
        private int calories;
        public Ingredient(int ID, bool amtType, string Name, int Cal, int amt)
        {
            id = ID;
            amountType = amtType;
            name = Name;
            calories = Cal;
            amount = amt;
        }
        public int getCalories()
        {
            calories = amount * calories;
            return calories;
        }

    }
}