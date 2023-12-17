using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Organizer
{
    public class Recipe
    {
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public string Instructions { get; set; }
        public int PrepTime { get; set; }
    }
}
