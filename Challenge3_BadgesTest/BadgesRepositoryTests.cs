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
            _badgesRepository.AddNewBadge(12346, new List<string> { "A6" });
            _badgesRepository.AddNewBadge(12347, new List<string> { "A7" });
            _badgesRepository.AddNewBadge(12347, new List<string> { "A8" });
        }

        [TestMethod]
        public void AddBadges_ShouldReturnTrue()
        {
            _badgesRepository.AddNewBadge(12345, new List<string> { "A5" });
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

        [TestMethod]
        public void BadgeByBadgeID_ShouldBeEqual()
        {
            _badgesRepository = new BadgesRepository();
        }

        [TestMethod]
        public void RemoveBadges_ShouldBeFalse()
        {
        //    _badgesRepository.RemoveDoorFromBadge(Convert.ToInt32(accessNum), doorRemoved);
        }

        [TestMethod]
        public void ViewAllBadges_ShouldViewBadges()
        {
        //    Dictionary<int, List<string>> doorDictionary = _badgesRepository.ViewAllBadges();
        }
    }
}
