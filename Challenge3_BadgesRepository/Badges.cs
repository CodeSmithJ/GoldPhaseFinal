using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_BadgesRepository
{
    public class Badges
    {
        public int BadgeID { get; set; }
        public List<string> Doors { get; set; }
        public string Name { get; set; }
        public List<string> List { get; }

        public Badges() { }
        public Badges(int badgeID, List<string> doors, string name)
        {
            BadgeID = badgeID;
            Doors = doors;
            Name = name;
        }

        public Badges(int badgeID, List<string> list)
        {
            BadgeID = badgeID;
            List = list;
        }
    }
}
