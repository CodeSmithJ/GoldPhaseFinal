using Challenge2_ClaimsRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge2_ClaimsTest
{
    [TestClass]
    public class ClaimRepositoryTests
    {
        private Claim _claimItem;
        private Claim _claimItem2;
        private ClaimRepository _claimRepo;

        [TestInitialize]
        public void Arrange()
        {
            _claimRepo = new ClaimRepository();
            _claimItem = new Claim(1, ClaimType.Car, "Car Accident on 465", 400.00, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27));
            _claimItem2 = new Claim(2, ClaimType.Home, "House fire in kitchen.", 4000.00, new DateTime(2018, 04, 11), new DateTime(2018, 04, 12));
            _claimRepo.AddNewClaim(_claimItem);
            _claimRepo.AddNewClaim(_claimItem2);
        }

        [TestMethod]
        public void AddClaim_ShouldAddClaim()
        {
            int expected = 1;
            int actual = _claimRepo.DisplayAllClaimList().Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DisplayAllClaims_AllClaims()
        {
            Claim claimItem = new Claim();
            ClaimRepository _claimRepo = new ClaimRepository();
            _claimRepo.AddNewClaim(claimItem);
            Queue<Claim> Queue = _claimRepo.DisplayAllClaimList();
            bool listClaims = Queue.Contains(claimItem);
            Assert.IsTrue(listClaims);
        }

        [TestMethod]
        public void PeekTheClaim_ShouldPeekClaim()
        {
            Claim peekClaim = _claimRepo.PeekClaim();

            Assert.AreEqual(_claimRepo.PeekClaim(), _claimItem);
        }

        [TestMethod]
        public void DequeueClaim_ShouldDequeueClaim()
        {
            _claimRepo.DequeueClaim();
            Claim newClaim = _claimItem2;
            Claim checkClaim = _claimRepo.PeekClaim();

            Assert.AreEqual(newClaim.ClaimID, checkClaim.ClaimID);
        }

    }
}
