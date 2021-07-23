using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace TheIdleGame
{
    public class Wood_Generator : Generator
    {   
        
        public Wood_Generator()
        {
           
           baseProduction = 1;//in x / second
           totalMultiplyer = 1;
           materialProduced = new Materials(1, "wood");
           requiredMaterial = null;
           requiredQuantity = 0 ;
        }
    }
}
