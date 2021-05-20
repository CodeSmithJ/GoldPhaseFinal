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
        public Dictionary<int,List<string>> ListAllBadges()
        {
            return _badgesDictionary;
        }
        public void AddNewBadge(int badgeID, List<string> doorNames)
        {
            _badgesDictionary.Add(badgeID, doorNames);
        }
        public void EditBadgeByBadgeID(int badgeID)
        {
            Badges badges = new Badges(badgeID, List<string>);
        }

        public void AddNewDoorToID(int badgeID, List<string> door)
        {
            _badgesDictionary.Remove(badgeID, List<string>, door);
        }
        public void RemoveDoorFromID(int badgeID, door)
        {
            _badgesDictionary.Remove(badgeID, List<string>);
        }

        //the key for the dictionary will be the BadgeID

        // The value for the dictionary will be the list of door names


    }
}
