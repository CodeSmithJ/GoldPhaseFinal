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
            {
                Console.Clear();
                Queue<Claim> claimList = _claimRepository.DisplayAllClaimList();

                Console.WriteLine("ClaimID     Type        Description       Amount    DateOfAccident    DateOfClaim    IsValid\n");
                foreach (Claim list in claimList)
                {
                    Console.WriteLine($"#   {list.ClaimID}        {list.TypeOfClaim}        {list.Description}  ${list.ClaimAmount}    {list.DateOfIncident.ToShortDateString()}         {list.DateOfClaim.ToShortDateString()}        {list.IsValid}");
                }
                Console.ReadLine();
            }
        }

        public void NextClaim()
        {
            Console.Clear();
            Console.WriteLine("Here are the details on the next claim to be handled: \n");

            Queue<Claim> claimList = _claimRepository.DisplayAllClaimList();
            Claim peekClaim = claimList.Peek();

            Console.WriteLine($"ID: {peekClaim.ClaimID}\n" +
            $"Type: {peekClaim.TypeOfClaim}\n" +
            $"Description: {peekClaim.Description}\n" +
            $"Amount: {peekClaim.ClaimAmount}\n" +
            $"DateOfAccident: {peekClaim.DateOfIncident.ToShortDateString()}\n" +
            $"DateOfClaim: {peekClaim.DateOfClaim.ToShortDateString()}\n" +
            $"IsValid: {peekClaim.IsValid}\n" +
            $"\n" +
            $"Do you want to deal with this claim now(y/n)");

            string userInput = Console.ReadLine();
            switch (userInput.ToLower())
            {
                case "y":
                    _claimRepository.DequeueClaim();
                    Console.WriteLine();
                    Console.WriteLine("You can now deal with this claim");
                    break;
                case "n":
                    Console.Clear();
                    Menu();
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }



        public void NewClaim()
        {
            Console.Clear();
            Claim newClaim = new Claim();
            Console.WriteLine("Enter the claim id:");
            int claimID = Convert.ToInt32(Console.ReadLine());
            newClaim.ClaimID = claimID;
            Console.WriteLine("Enter the claim type: \n" +
                "1. Car \n" +
                "2. Home \n" +
                "3. Theft");
            int claimType = Convert.ToInt32(Console.ReadLine());
            newClaim.TypeOfClaim = (ClaimType)claimType;
            Console.WriteLine("Claim a claim description: ");
            newClaim.Description = Console.ReadLine();
            Console.WriteLine("Amount of Damage: ");
            string claimAmount = Console.ReadLine();
            newClaim.ClaimAmount = Convert.ToDouble(claimAmount);
            Console.WriteLine("Date Of Accident: ");
            string accidentDate = Console.ReadLine();
            newClaim.DateOfIncident = DateTime.Parse(accidentDate);
            Console.WriteLine("Date of Claim: ");
            string claimDate = Console.ReadLine();
            newClaim.DateOfClaim = DateTime.Parse(claimDate);
            _claimRepository.AddNewClaim(newClaim);
            Console.WriteLine();
            if (newClaim.IsValid == true)
            {
                Console.WriteLine("This claim is valid.");
            }
            else
            { Console.WriteLine("This claim is invalid."); }
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
