using Challenge1_CafeRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenge1_CafeTest
{
    [TestClass]
    public class MenuRepositoryTests
    {
        [TestMethod]
        public void AddToItemOrder_ShouldReturnTrue()
        {
            MenuItem menuItem = new MenuItem();
            MenuRepository repository = new MenuRepository();
            bool testResult = repository.AddToOrder(menuItem);
            Assert.IsTrue(testResult);
        }
    }
}
