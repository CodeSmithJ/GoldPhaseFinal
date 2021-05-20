using Challenge3_BadgesRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge3_BadgesTest
{
    [TestClass]
    public class BadgesRepositoryTests
    {
        private BadgesRepository _badgesRepository;

        [TestInitialize]
        public void Arrange()
        {
            _badgesRepository = new BadgesRepository();
            _badgesRepository.AddNewBadge(12345, new List<string> { "A5" });
        }
        [TestMethod]
        public void ViewBadgesAddBadgesTested_ShouldReturnTrue()
        {
            BadgesRepository viewRepository = new BadgesRepository();
            Dictionary<int, List<string>> checkDictonary = viewRepository.ViewAllBadges();
            if (checkDictonary.ContainsKey(12345))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
