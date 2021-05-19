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

        public void Arrange()
        {
            _claimRepo = new ClaimRepository();
            _claimItem = new Claim(1, ClaimType.Car, "Car Accident on 465", 400.00, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27));
            _claimItem2 = new Claim(2, ClaimType.Home, "House fire in kitchen.", 4000.00, new DateTime(2018, 04, 11), new DateTime(2018, 04, 12));
            _claimRepo.AddNewClaim(_claimItem);
        }

        [TestMethod]
        public void DisplayAllClaims_AllClaims()
        {

        }

        [TestMethod]
        public void GetClaimByID_ShouldGetByID()
        {
            Claim claimItem = new Claim();
            ClaimRepository repository = new ClaimRepository();
            repository.AddNewClaim(claimItem);
            Queue<Claim> directory = repository.DisplayAllClaims();
            bool claimHasID = directory.Contains(claimItem);
            Assert.IsTrue(claimHasID);
        }

        [TestMethod]
        public void AddClaim_ShouldAddClaim()
        {
            Claim claimItem = new Claim();
            ClaimRepository repository = new ClaimRepository();
            bool wasAdded = repository.AddNewClaim(claimItem);
            Assert.IsTrue(wasAdded);
        }

        [TestMethod]
        public void PeekClaim_ShouldReturnSame()
        {

        }

        [TestMethod]
        public void UpdateClaim_ShouldUpdate()
        {
            _claimRepo.UpdateClaim(1, new Claim(4, ClaimType.Car, "Car Accident on 465", 400.00, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27)));
            Assert.AreEqual(_claimItem.ClaimID, 1);
        }
        [TestMethod]
        public void RemoveClaim_ShouldDelete()
        {
            bool wasDeleted = _claimRepo.RemoveClaim(1);
            Assert.IsTrue(wasDeleted);
        }
    }
}
