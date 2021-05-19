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
        public List<MenuItem> AllItems()
        {
            return _menuItem;
        }

        public void AddToOrder(MenuItem newItem)
        {
            _menuItem.Add(newItem);
        }

        public MenuItem GetOrderByCombo(int combo)
        {
            foreach (MenuItem meal in _menuItem)
            {
                if (meal.Combo == combo)
                {
                    return meal;
                }
            }
            return null;
        }

        public bool RemoveItem(int itemToRemove)
        {
            MenuItem mealToRemove = GetOrderByCombo(itemToRemove);
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
