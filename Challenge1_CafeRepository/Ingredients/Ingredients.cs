using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_CafeRepository.Ingredients
{
    public class Ingredients : MenuItem
    {
        public List<Ingredients> Ingredient { get; set; }
    }
    public class Ingredient
    {
        public string Chicken { get; set; }
        public string Beef { get; set; }
        public string Fish { get; set; }
        public string Cheese { get; set; }
        public string Bun { get; set; }

    }
}
