using Challenge1_CafeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_CafeConsole
{
    public class ProgramUI
    {
        private MenuRepository _menuRepo = new MenuRepository();
        public void Run()
        {
            SaveOrderList();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Meal\n" +
                    "2. View All Meals\n" +
                    "3. View All Ingredients\n" +
                    "4. Update Meal\n" +
                    "5. Remove Meal\n" +
                    "6. Exit");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        //CreateNewContent
                        CreateNewMenuItem();
                        break;
                    case "2":
                    case "two":
                        //ViewAllContent
                        DisplayAllMenuItems();
                        break;
                    case "3":
                    case "three":
                        //View Content By Title
                        DisplayIngredients();
                        break;
                    case "4":
                    case "four":
                        //Update Existing Content
                        UpdateMenuItem();
                        break;
                    case "5":
                    case "five":
                        //Delete Existing Content
                        DeleteMenuItem();
                        break;
                    case "6":
                    case "six":
                        //Exit
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter 1 - 5");
                        break;
                }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateNewMenuItem()
        {
            Console.Clear();
            MenuItem newMenuItem = new MenuItem();

            Console.WriteLine("Add New Combo:\n" +
                "\n" +
                "Current Combos\n" +
                "1. ChickenNuggets\n" +
                "2. CheeseBurger\n" +
                "3. FishSandwich\n" +
                "4. ChickenSandwich\n" +
                "5. HamBurger\n");
            string comboAsString = Console.ReadLine();
            int comboAsInt = Convert.ToInt32(comboAsString);
            newMenuItem.NumberMeal = (ComboMeal)comboAsInt;
            _menuRepo.AddToOrder(newMenuItem);

            Console.WriteLine("Menu Item Name?");
            newMenuItem.MealName = Console.ReadLine();

            Console.WriteLine("Describe This Item");
            newMenuItem.Description = Console.ReadLine();

            Console.WriteLine("How Much For This Item?");
            newMenuItem.Price = Convert.ToDouble(Console.ReadLine());

        }
        private void DisplayAllMenuItems()
        {
            Console.Clear();
            List<MenuItem> allItems = _menuRepo.AllItems();
            foreach (MenuItem menuItem in allItems)
            {
                Console.WriteLine($"Combo: {menuItem.NumberMeal}\n" +
                    $"Combo: {menuItem.MealName}\n" +
                    $"Price: {menuItem.Price}");
            }
        }
        private void DisplayIngredients()
        {

        }

        private void UpdateMenuItem()
        {
            Console.Clear();
            DisplayAllMenuItems();
            Console.WriteLine("Enter the Meal Name you want to update");
            string oldMenuItem = Console.ReadLine();
            MenuItem newMenuItem = new MenuItem();

            Console.WriteLine("Update Meal:\n" +
                "1. ChickenNuggets\n" +
                "2. CheeseBurger\n" +
                "3. FishSandwich\n" +
                "4. ChickenSandwich\n" +
                "5. HamBurger\n");
            string comboAsString = Console.ReadLine();
            int comboAsInt = Convert.ToInt32(comboAsString);
            newMenuItem.NumberMeal = (ComboMeal)comboAsInt;
            _menuRepo.AddToOrder(newMenuItem);

            Console.WriteLine("Menu Item Name?");
            newMenuItem.MealName = Console.ReadLine();

            Console.WriteLine("Describe This Item");
            newMenuItem.Description = Console.ReadLine();

            Console.WriteLine("How Much For This Item?");
            newMenuItem.Price = Convert.ToDouble(Console.ReadLine());

            bool wasUpdated = _menuRepo.UpdateMenuItem(oldMenuItem, newMenuItem);
            if (wasUpdated)
            {
                Console.WriteLine("Item successfully updated!");
            }
            else
            {
                Console.WriteLine("Item was not updated");
            }

        }
        private void DeleteMenuItem()
        {
            Console.Clear();
            DisplayAllMenuItems();

            Console.WriteLine("Enter Item To Remove");
            bool wasRemoved = _menuRepo.RemoveItem(Console.ReadLine());
            if (wasRemoved)
            {
                Console.WriteLine("Item Removed");
            }
            else
            {
                Console.WriteLine("Item was NOT removed!");
            }

        }
        private void SaveOrderList()
        {
            MenuItem nugs = new MenuItem(ComboMeal.ChickenNuggets, "Chicken Nuggets", "8 Chicken Nuggets", 6.50);
            _menuRepo.AddToOrder(nugs);
        }
    }
}
