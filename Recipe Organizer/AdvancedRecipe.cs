using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Organizer
{
    public class AdvancedRecipe : Recipe
    {
        public int advancedRecipeId { get; set; }
        public string ChefTips { get; set; }
        public int DifficultyScore { get; set; }
    }
}
