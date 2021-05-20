using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_BadgesRepository
{
    public class BadgesRepository
    {
        public Dictionary<int, List<<string>> _badgesDictoinary = new Dictionary<int, List<string>>();
        //Create a Dictionary of badges
        public void AddNewBadge()
        {
            BadgeList.Add("Mahesh Chand", 35);    
            AuthorList.Add("Mike Gold", 25);    
            AuthorList.Add("Praveen Kumar", 29);    
            AuthorList.Add("Raj Beniwal", 21);    
            AuthorList.Add("Dinesh Beniwal", 84); 
        }

        public void UpdateDoors()
        {

        }

        //the key for the dictionary will be the BadgeID
        Dictionary<string, float> PriceList = new Dictionary<string, float>(3);

        // The value for the dictionary will be the list of door names
    }
}
