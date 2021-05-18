using Challenge3_BadgesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_BadgesConsole
{
    class ProgramUI
    {
        private BadgesRepository _badgesRepo = new BadgesRepository();
        public void Run()
        {
            SaveBadges();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Choose a menu Option:\n" +
                     "1. Add a badge\n" +
                     "2. Edit a badge\n" +
                     "3. List all badges\n" +
                     "4. Exit");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        //Add a badge
                        AddNewBadge();
                        break;
                    case "2":
                    case "two":
                        //edit a badge
                        UpdateBadge();
                        break;
                    case "3":
                    case "three":
                        //List all badges
                        ViewAllBadges();
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
        public void AddNewBadge()
        {

        }
        public void UpdateBadge()
        {

        }
        public void ViewAllBadges()
        {

        }
        public void SaveBadges()
        {

        }
    }
}
