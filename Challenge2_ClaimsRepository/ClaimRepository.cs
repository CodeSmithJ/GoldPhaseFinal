using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_ClaimsRepository
{
    public class ClaimRepository
    {
        // See All Claims
        public void DisplayAllClaims()
        {
            int[] claimID = { 1, 2, 3};
            decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80,
                                 16.75m };

            Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
            for (int ctr = 0; ctr < claimID.Length; ctr++)
                Console.WriteLine("{0,-20} {1,5:N1}", claimID[ctr], hours[ctr]);

        }
        // Take care of next claim

        //Enter new claim

    }
}
