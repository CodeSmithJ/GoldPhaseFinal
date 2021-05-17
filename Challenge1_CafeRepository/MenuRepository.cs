using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_CafeRepository
{
    public class MenuRepository
    {
        public List<MenuItem> _menuItem = new List<MenuItem>();

        public bool AddToOrder(MenuItem newItem)
        {
            int itemOrder = _menuItem.Count;
            _menuItem.Add(newItem);
            bool canConfirm = (_menuItem.Count > itemOrder) ? true : false;
            return canConfirm;
        }

        public List<MenuItem> AllItems()
        {
            return _menuItem;
        }

        public MenuItem GetOrderByMealName(string mealName)
        {
            foreach (MenuItem meal in _menuItem)
            {
                if (meal.MealName.ToLower() == mealName.ToLower())
                {
                    return meal;
                }
            }
            return null;
        }

        public MenuItem ComboNumber(ComboMeal numberMeal)
        {
            foreach (MenuItem meal in _menuItem)
            {
                if (meal.NumberMeal == numberMeal)
                {
                    return meal;
                }
            }
            return null;
        }
        public bool UpdateMenuItem(string mealName, MenuItem updatedMeal)
        {
            MenuItem oldItem = GetOrderByMealName(mealName);
            if (oldItem != null)
            {
                oldItem.NumberMeal = updatedMeal.NumberMeal;
                oldItem.MealName = updatedMeal.MealName;
                oldItem.Description = updatedMeal.Description;
                oldItem.Price = updatedMeal.Price;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveItem(string itemToRemove)
        {
            MenuItem mealToRemove = GetOrderByMealName(itemToRemove);
            if (mealToRemove == null)
            {
                return false;
            }
            else
            {
                _menuItem.Remove(mealToRemove);
                return true;
            }
        }
    }
}
