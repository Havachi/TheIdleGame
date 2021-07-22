using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIdleGame
{
    public class Items
    {
        public int ID;
        public string name;
        public double quantityOwned;

        public void Add(double qty)
        {
            quantityOwned += qty;
        }
        public void Sub(double qty)
        {
            quantityOwned -= qty;
        }
    }
    public class Currency : Items
    {
       

    }
    public class Materials : Items
    {
        public Materials(int materialID,string materialName)
        {
            this.ID = materialID;
            this.name = materialName;
        }
    }
    
}
