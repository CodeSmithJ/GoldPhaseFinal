using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_CafeRepository
{
    public class MenuItem
    {
        public int Combo { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public MenuItem() { }
        public MenuItem(int combo, string mealName, string ingredients, string description, double price)
        {
            Combo = combo;
            MealName = mealName;
            Ingredients = ingredients;
            Description = description;
            Price = price;
        }
    }
}
