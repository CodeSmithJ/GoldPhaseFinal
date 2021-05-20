using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_ClaimsRepository
{
    public class ClaimRepository
    {
        private Queue<Claim> _claimList = new Queue<Claim>();
        public Queue<Claim> DisplayAllClaimList()
        {
            return _claimList;
        }
        public Claim PeekClaim()
        {
            return _claimList.Peek();
        }
        public Claim DequeueClaim() //Streaming Repository Start Count Check
        {
            return _claimList.Dequeue();
        }
        public void AddNewClaim(Claim newClaim)
        {
            _claimList.Enqueue(newClaim);
        }
    }
}

