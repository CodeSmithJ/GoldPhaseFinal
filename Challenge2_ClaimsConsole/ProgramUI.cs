using Challenge2_ClaimsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_ClaimsConsole
{
    class ProgramUI
    {
        private ClaimRepository _claimRepo = new ClaimRepository();
        public void Run()
        {
            SaveClaims();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Choose a menu Option:\n" +
                     "1. See All Claims\n" +
                     "2. Take care of next claim\n" +
                     "3. Enter a new claim\n" +
                     "4. Exit");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        //SeeAllClaims
                        ViewAllClaims();
                        break;
                    case "2":
                    case "two":
                        //TakeCareOfNextClaim
                        NextClaim();
                        break;
                    case "3":
                    case "three":
                        //EnterNewClaim
                        NewClaim();
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
    }
}
