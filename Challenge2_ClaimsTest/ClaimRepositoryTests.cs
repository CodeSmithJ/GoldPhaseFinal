using Challenge2_ClaimsRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Claims;

namespace Challenge2_ClaimsTest
{
    [TestClass]
    public class ClaimRepositoryTests
    {
        private Claim _claimItem;
        private ClaimRepository _claimRepo;

        public void Arrange()
        {
            _claimRepo = new ClaimRepository();
            _claimItem = new Claim(1, ClaimType.Car, "Car Accident on 465", 400.00, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27));
            _claimRepo.AddNewClaim(_claimItem);
        }

        [TestMethod]
        public void DisplayAllClaims_AllClaims()
        {
        }

        [TestMethod]
        public void GetClaimByID_ShouldGetByID()
        {
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
        public void RemoveClaim()
        {
            bool wasDeleted = _claimRepo.RemoveClaim(1);
            Assert.IsTrue(wasDeleted);
        }
    }
}
