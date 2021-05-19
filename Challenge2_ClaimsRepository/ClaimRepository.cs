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
        public Queue<Claim> DisplayAllClaimList()
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
        public bool AddNewClaim(Claim newClaim)
        {
            int claimOrder = _claimList.Count;
            _claimList.Enqueue(newClaim);
            bool canConfirm = (_claimList.Count > claimOrder);
            return canConfirm;
        }
        //Peek Claim
        public Claim PeekClaim()
        {
            return _claimList.Peek();
        }
        //Update Claim
        public bool UpdateClaim(int claimID, Claim updatedID)
        {
            Claim oldClaim = GetClaimByID(claimID);
            if (oldClaim != null)
            {
                oldClaim.ClaimID = updatedID.ClaimID;
                oldClaim.TypeOfClaim = updatedID.TypeOfClaim;
                oldClaim.Description = updatedID.Description;
                oldClaim.ClaimAmount = updatedID.ClaimAmount;
                oldClaim.DateOfIncident = updatedID.DateOfIncident;
                oldClaim.DateOfClaim = updatedID.DateOfClaim;
                return true;
            }
            else
            {
                return false;
            }
        }
        // Dequeue claim
        public bool RemoveClaim(int iDToRemove)
        {
            Claim claimToRemove = GetClaimByID(iDToRemove);
            if (claimToRemove == null)
            {
                return false;
            }
            else
            {
                _claimList.Dequeue();
                return true;
            }
        }
    }
}

