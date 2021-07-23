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

        public string PCs { get; internal set; }

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

    /*
     * 
     * Known Material ID :
     * 0 -> wood
     * 1 -> leaves
     * 2 ->
     * 63 -> null (nothing)
     * 
     * **/
    public class Materials : Items
    {
        public Materials(int materialID,string materialName)
        {
            this.ID = materialID;
            this.name = materialName;
        }
    }
    
}
