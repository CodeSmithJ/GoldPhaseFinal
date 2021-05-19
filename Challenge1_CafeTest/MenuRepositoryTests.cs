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
            _item = new MenuItem(1, "Chicken Nuggets", "Dino Nuggets", "8 Nuggets", 5.99);
        }

        [TestMethod]
        public void AddToItemOrder_ShouldReturnTrue()
        {
            _repo.AddToOrder(_item);
            string newMealName = "Dino Nuggets";
            string oldMealName = "Chicken Nuggets";
            Assert.AreEqual(oldMealName, newMealName);
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
        public void RemoveItem_ShouldDelete()
        {
            bool wasDeleted = _repo.RemoveItem("Chicken Nuggets");
            Assert.IsTrue(wasDeleted);
        }
    }
}
