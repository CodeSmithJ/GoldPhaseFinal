using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_CafeRepository
{
    public enum ComboMeal { ChickenNuggets = 1, CheeseBurger, FishSandwich, ChickenSandwich, HamBurger }
    public class MenuItem
    {
        public ComboMeal NumberMeal { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public MenuItem() { }
        public MenuItem(ComboMeal numberMeal, string mealName, string description, double price)
        {
            NumberMeal = numberMeal;
            MealName = mealName;
            Description = description;
            Price = price;
        }
    }
}
