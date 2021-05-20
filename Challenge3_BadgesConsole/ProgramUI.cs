using Challenge3_BadgesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_BadgesConsole
{
    public class ProgramUI
    {
        private BadgesRepository _badgesRepository = new BadgesRepository();
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
        private void AddNewBadge()
        {
            Console.Clear();
            Console.WriteLine("What is the number on the badge?");
            string accessNum = Console.ReadLine();
            DoorAccess(Convert.ToInt32(accessNum));
            Console.WriteLine("List a door that it needs access to: ");
            List<string> accessDoor = new List<string> { Console.ReadLine() };
            bool addDoor = true;
            while (addDoor)
            {
                Console.WriteLine("Any other doors (y/n) ?");
                string nextDoor = Console.ReadLine().ToLower();
                switch (nextDoor)
                {
                    case "y":
                        {
                            Console.WriteLine("List a door that it needs access to: ");
                            accessDoor.Add(Console.ReadLine());
                            break;
                        }
                    case "n":
                        {
                            addDoor = false;
                            Console.Clear();
                            Menu();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                _badgesRepository.AddNewBadge(Convert.ToInt32(accessNum), accessDoor);
            }
        }
        private void DoorAccess(int accessNum)
        {
            Dictionary<int, List<string>> doorDictionary = _badgesRepository.ViewAllBadges();
            Console.WriteLine($"{accessNum} has access to: ");
            Badges badges = _badgesRepository.BadgeByBadgeID(accessNum);
            foreach (string accessDoor in badges.List)
            {
                Console.Write($"{accessDoor} \n");
            }
        }
        private void UpdateBadge()
        {
            Console.WriteLine("What is the badge number to update?");
            string accessNum = Console.ReadLine();
            DoorAccess(Convert.ToInt32(accessNum));
            Console.WriteLine("What would you like to do? \n" +
                "1. Remove a Door \n" +
                "2. Add a Door \n");
            string addRemoveDoor = Console.ReadLine();
            switch (addRemoveDoor)
            {
                case "1":
                    {
                        Console.WriteLine("Which door would you like to remove?");
                        string doorRemoved = Console.ReadLine();
                        _badgesRepository.RemoveDoorFromBadge(Convert.ToInt32(accessNum), doorRemoved);
                        DoorAccess(Convert.ToInt32(accessNum));
                        Console.WriteLine("Door removed.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Which door would you like to add?");
                        string doorAdded = Console.ReadLine();
                        _badgesRepository.AddNewDoorToBadge(Convert.ToInt32(accessNum), doorAdded);
                        DoorAccess(Convert.ToInt32(accessNum));
                        Console.WriteLine("Door added");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                default:
                    {
                        Console.ReadLine();
                        break;
                    }
            }
        }
        private void ViewAllBadges()
        {
            Dictionary<int, List<string>> _badgeDictionary = _badgesRepository.ViewAllBadges();
            foreach (KeyValuePair<int, List<string>> badges in _badgeDictionary)
            {
                Console.WriteLine($"Badge#: {badges.Key} \n" + "Door Access:");
                foreach (string doors in badges.Value)
                {
                    Console.Write($" {doors} ");
                }
                Console.WriteLine("\n========================");
            }
            Console.ReadLine();
        }
        private void SaveBadges()
        {
            _badgesRepository.AddNewBadge(12345, new List<string> { "A7" });
            _badgesRepository.AddNewBadge(22345, new List<string> { "A1", "A4", "B1", "B2" });
            _badgesRepository.AddNewBadge(32345, new List<string> { "A4", "A5" });
        }
    }
}
