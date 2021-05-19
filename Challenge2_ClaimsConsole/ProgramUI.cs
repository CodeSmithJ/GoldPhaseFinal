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
        public ClaimRepository _claimRepository = new ClaimRepository();
        public void Run()
        {
            SavedClaim();
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

        public void ViewAllClaims()
        {

        }
        public void NextClaim()
        {
            Console.Write("Check Next Claim? (y/n)?");
            switch (Console.ReadLine().ToLower())
            {
                case "y":
                case "yes":
                    _claimRepository.();
                    Console.WriteLine("Claim Removed From Queue");
                    break;
                case "n":
                case "no":
                    break;
                default:
                    Console.WriteLine("Not A Valid Input");
                    break;
            }
        }

        public void NewClaim()
        {

        }

        public void SavedClaim()
        {
            Claim carAccident = new Claim(1, ClaimType.Car, "Car accident on 465.", 400.00, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27));
            Claim homeFire = new Claim(2, ClaimType.Home, "House fire in kitchen.", 4000.00, new DateTime(2018, 04, 11), new DateTime(2018, 04, 12));
            Claim stolenCakes = new Claim(3, ClaimType.Theft, "Stolen pancakes.", 4.00, new DateTime(2018, 04, 27), new DateTime(2018, 06, 01));

            _claimRepository.AddNewClaim(carAccident);
            _claimRepository.AddNewClaim(homeFire);
            _claimRepository.AddNewClaim(stolenCakes);
        }
    }
}
