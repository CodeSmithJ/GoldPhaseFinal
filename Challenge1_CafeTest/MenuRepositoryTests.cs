using Challenge1_CafeRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge1_CafeTest
{
    [TestClass]
    public class MenuRepositoryTests
    {
        private MenuItem _item;
        private MenuRepository _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepository();
            _item = new MenuItem(ComboMeal.ChickenNuggets, "Chicken Nuggets", "8 Piece Nugget Meal", 5.99);
        }

        [TestMethod]
        public void AddToItemOrder_ShouldReturnTrue()
        {
            MenuItem menuItem = new MenuItem();
            MenuRepository repository = new MenuRepository();
            bool testResult = repository.AddToOrder(menuItem);
            Assert.IsTrue(testResult);
        }

        [TestMethod]
        public void GetOrderByName_ShouldGetName()
        {
            MenuItem menuItem = new MenuItem();
            MenuRepository repository = new MenuRepository();
            repository.AddToOrder(menuItem);
            List<MenuItem> directory = repository.AllItems();
            bool menuHasMeal = directory.Contains(menuItem);
            Assert.IsTrue(menuHasMeal);
        }

        [TestMethod]
        public void GetOrderByCombo_ShouldGetCombo()
        {
            MenuItem menuItem = new MenuItem();
            MenuRepository repository = new MenuRepository();
            repository.AddToOrder(menuItem);
            List<MenuItem> directory = repository.AllItems();
            bool menuHasMeal = directory.Contains(menuItem);
            Assert.IsTrue(menuHasMeal);
        }

        [TestMethod]
        public void UpdateMenu_MenuShouldUpdate()
        {
            _repo.UpdateMenuItem("Chicken Nuggets", new MenuItem(ComboMeal.ChickenNuggets, "New Chicken Nuggets", "8 Piece Nugget", 7.50));
            Assert.AreEqual(_item.MealName, "New Chicken Nuggets");
        }


        [TestMethod]
        public void RemoveItem_ShouldDelete()
        {
            bool wasDeleted = _repo.RemoveItem("Chicken Nuggets");
            Assert.IsTrue(wasDeleted);
        }
    }
}
