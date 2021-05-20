using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_BadgesRepository
{
    public class BadgesRepository
    {
        public Dictionary<int, List<string>> _badgesDictionary = new Dictionary<int, List<string>>();
        public Dictionary<int, List<string>> ViewAllBadges()
        {
            return _badgesDictionary;
        }
        public void AddNewBadge(int badgeID, List<string> newDoor)
        {
            _badgesDictionary.Add(badgeID, newDoor);
        }
        public void AddNewDoorToBadge(int badgeID, string addDoor)
        {
            _badgesDictionary[badgeID].Add(addDoor);
        }
        public void RemoveDoorFromBadge(int badgeID, string removeDoor)
        {
            _badgesDictionary[badgeID].Remove(removeDoor);
        }
    }
}
