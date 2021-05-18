using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_ClaimsRepository
{
    public class ClaimRepository
    {
        public Queue<Claim> _claimList = new Queue<Claim>();
        // See All Claims
        public Queue<Claim> DisplayAllClaims()
        {
            return _claimList;
        }
        // Get claim by id
        public Claim GetClaimByID(int claimID)
        {
            foreach (Claim claim in _claimList)
            {
                if (claimID == claim.ClaimID)
                {
                    return claim;
                }
            }
            Console.WriteLine("No Claim With That ID");
            Console.ReadLine();
            return null;
        }
        //Enter new claim
        public void AddNewClaim(Claim newClaim)
        { 
            _claimList.Enqueue(newClaim);
        }
        // Dequeue claim
        public void RemoveClaim()
        {
            _claimList.Dequeue();
        }
    }
}

