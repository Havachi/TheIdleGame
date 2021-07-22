using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIdleGame
{
    public class Generator : Items
    {
        public double baseProduction;//in x / second
        public double totalMultiplyer;

        public Materials materialProduced;
        public Materials requiredMaterial;
        public double requiredQuantity;
        public Generator()
        {
            baseProduction = 0;
            totalMultiplyer = 0;
            materialProduced = null;
            requiredMaterial = null;
            requiredQuantity = 0;
        }
        public Generator(int genID)
        {
            Generator tmp = new Generator();
            if (genID == 1)
            {
                tmp = new Wood_Generator();
            }
            else if (genID == 2)
            {
                tmp = new Iron_Generator();
            }
            this.baseProduction = tmp.baseProduction;
            this.totalMultiplyer = tmp.totalMultiplyer;
            this.materialProduced = tmp.materialProduced;
            this.requiredMaterial = tmp.requiredMaterial;
            this.requiredQuantity = tmp.requiredQuantity;
        }

        private double GetTotalProduction()
        {
            return baseProduction * quantityOwned * totalMultiplyer;
        }
        private double GetTotalRequiredMaterial()
        {
            return requiredQuantity * quantityOwned;
        }
        public void Generate(Inventory inventory)
        {
            double totalProduction = GetTotalProduction();
            if (inventory.inv[requiredMaterial.ID].quantityOwned >= GetTotalRequiredMaterial())
            {
                inventory.inv[materialProduced.ID].quantityOwned += GetTotalRequiredMaterial();
            }
        }

    }

}
