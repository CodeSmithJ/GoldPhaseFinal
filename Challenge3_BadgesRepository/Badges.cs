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
        public string Doors { get; set; }
        public string Name { get; set; }

        public Badges() { }
        public Badges(int badgeID, string doors, string name)
        {
            BadgeID = badgeID;
            Doors = doors;
            Name = name;
        }
    }
}
