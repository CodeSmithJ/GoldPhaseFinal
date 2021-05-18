using Challenge2_ClaimsRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Claims;

namespace Challenge2_ClaimsTest
{
    [TestClass]
    public class ClaimRepositoryTests
    {
        public void Arrange()
        {
            _repo = new MenuRepository();
            _item = new MenuItem(ComboMeal.ChickenNuggets, "Chicken Nuggets", "8 Piece Nugget Meal", 5.99);
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
        }

        [TestMethod]
        public void RemoveClaimFromMenu()
        {
        }
    }
}
