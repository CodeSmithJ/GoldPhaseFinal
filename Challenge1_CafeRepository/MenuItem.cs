using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_CafeRepository
{
    public class MenuItem
    {
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public MenuItem() { }
        public MenuItem(string mealName, string ingredients, string description, double price)
        {
            MealName = mealName;
            Ingredients = ingredients;
            Description = description;
            Price = price;
        }
    }
}
