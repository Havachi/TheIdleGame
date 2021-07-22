using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIdleGame
{
    public class Iron_Generator : Generator
    {   
        
        public Iron_Generator()
        {
           baseProduction = 0.5;//in x / second
           totalMultiplyer = 1;
           materialProduced = new Materials(2, "iron_ore");
           requiredMaterial = null;
           requiredQuantity = 0;
        }
    }
}
