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
                    "2. Remove Meal\n" +
                    "3. View All Combos\n" +
                    "4. Exit");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        CreateNewMenuItem();
                        break;
                    case "2":
                    case "two":
                        DeleteMenuItem();
                        break;
                    case "3":
                    case "three":
                        DisplayAllMenuItems();
                        break;
                    case "4":
                    case "four":
                        //Exit
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter 1 - 4");
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
            MenuItem newItem = new MenuItem();

            Console.WriteLine("Whats The Number For New Combo?");
            newItem.Combo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Menu Item Name?");
            newItem.MealName = Console.ReadLine();

            Console.WriteLine("Describe The Item...");
            newItem.Description = Console.ReadLine();

            Console.WriteLine("Whats Its Ingredients?");
            newItem.Ingredients = Console.ReadLine();

            Console.WriteLine("How Much For This Item?");
            newItem.Price = Convert.ToDouble(Console.ReadLine());

            _menuRepo.AddToOrder(newItem);

        }
        private void DisplayAllMenuItems()
        {
            Console.Clear();
            List<MenuItem> allItems = _menuRepo.AllItems();
            foreach (MenuItem menuItem in allItems)
            {
                Console.WriteLine($"Combo: {menuItem.Combo}\n" +
                    $"Name: {menuItem.MealName}\n" +
                    $"Description: {menuItem.Description}\n" +
                    $"Ingredients: {menuItem.Ingredients}\n" +
                    $"Price: {menuItem.Price}\n" +
                    $"========================================================");
            }
            Console.WriteLine();
        }

        private void DeleteMenuItem()
        {
            Console.Clear();
            DisplayAllMenuItems();

            Console.WriteLine("Enter Combo Number To Remove");
            bool wasRemoved = _menuRepo.RemoveItem(Convert.ToInt32(Console.ReadLine()));
            if (wasRemoved)
            {
                Console.WriteLine("Item was Removed!");
            }
            else
            {
                Console.WriteLine("Item was NOT Removed!");
            }

        }
        private void SaveOrderList()
        {
            MenuItem nugs = new MenuItem(1, "Chicken Nuggets", "8 Nuggets, French Fries", "8 Dino Nuggets", 6.50);
            MenuItem chezburg = new MenuItem(2, "Cheeseburger", "Beef Patty, American Cheese, Lettuce", "Classic Cheese Burger", 5.25);
            MenuItem fishsand = new MenuItem(3, "Chicken Sandwich", "Chicken Patty, Pepperjack Cheese, Lettuce", "Classic Chicken Sandwich", 4.50);
            MenuItem chicksand = new MenuItem(4, "Fish Fillet", "Fish Fillet, American Cheese, Tarter Sauce ", "Fish Fillet Sandwich", 1.50);
            MenuItem hamburg = new MenuItem(5, "Hamburger", "Beef Patty, American Cheese, Lettuce", "Classic Hamburger", 5.50);
            _menuRepo.AddToOrder(nugs);
            _menuRepo.AddToOrder(chezburg);
            _menuRepo.AddToOrder(fishsand);
            _menuRepo.AddToOrder(chicksand);
            _menuRepo.AddToOrder(hamburg);
        }
    }
}
