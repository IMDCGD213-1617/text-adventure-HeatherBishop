using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    struct Direction //Use struct instead of class
    {
        public const string North = "north"; //Create variable (constant value), cannot be changed.
        public const string South = "south";
        public const string East = "east";
        public const string West = "west";



        //Is Valid Direction()
        public static bool IsValidDirection()
        {
            return true;
        }
            
    }
}
