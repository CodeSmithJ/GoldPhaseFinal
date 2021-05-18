using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenge3_BadgesTest
{
    [TestClass]
    public class BadgesRepositoryTests
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

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
