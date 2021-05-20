using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_BadgesRepository
{
    public class BadgesRepository
    {
        private Dictionary<int, List<string>> _badgesDictionary = new Dictionary<int, List<string>>();
        public Dictionary<int, List<string>> ViewAllBadges()
        {
            return _badgesDictionary;
        }

        public void AddNewBadge(int badgeID, List<string> idDoors)
        {
            _badgesDictionary.Add(badgeID, idDoors);
        }

        public void AddNewDoorToBadge(int badgeID, string addDoor)
        {
            _badgesDictionary[badgeID].Add(addDoor);
        }

        public void RemoveDoorFromBadge(int badgeID, string removeDoor)
        {
            _badgesDictionary[badgeID].Remove(removeDoor);
        }

        public Badges BadgeByBadgeID(int badgeID)
        {
            Badges badges = new Badges(badgeID, _badgesDictionary[badgeID]);
            return badges;
        }
    }
}
