using System;

using UnityEngine;
using UnityEngine.UI;

namespace TheIdleGame
{
    public class Idler : MonoBehaviour
    {
        private Game game;

        public Canvas canvas;
        //Idler Lables
        public Text lblIdlerCount;
        public Text lblIdleNextBonus;
        public Text lblIdleCost;
        //Idler Upgrade Lables
        public Text lblIdlerUpgradeNextBonus;
        public Text lblIdlerUpgradeCost;

        //Idler
        public double idlerCount;
        public double idlerCost;
        public double idlerBaseCost;
        public double idlerGrowth;
        public double idlerBonus;
        public double idlerBaseBonus;
        public double idlerMult;

        //Idler Upgrade
        public double upgradeIdlerTier;
        public double upgradeIdlerCost;
        public double upgradeIdlerBaseCost;
        public double upgradeidlerGrowth;
        public double upgradeIdlerBonus;
        public double upgradeIdlerBaseBonus;

        // Start is called before the first frame update
        void Start()
        {
            /*
            game = GetComponentInParent<Game>();
            //Idler
            idlerCount = 0;         
            idlerBaseCost = 5;
            idlerCost = idlerBaseCost;
            idlerGrowth = 1.07;      
            idlerBaseBonus = 1;
            idlerBonus = 0;
            idlerMult = 1;
            //Idler Upgrade
            upgradeIdlerTier = 0;     
            upgradeIdlerBaseCost = 100;
            upgradeIdlerCost = upgradeIdlerBaseCost;
            upgradeidlerGrowth = 1.12;
            upgradeIdlerBaseBonus = 2;
            upgradeIdlerBonus = 0;*/

        }

        // Update is called once per frame
        void Update()
        {
            //Idler
            lblIdlerCount.text = "Idlers: " + idlerCount;
            if (idlerCount == 0) {
                lblIdleNextBonus.text = "+" + (Math.calculate_NextBonus(idlerBaseBonus, 1, upgradeIdlerBonus > 0 ? upgradeIdlerBonus : 1) -  idlerBonus).ToString("N2") + " $/s";
            }
            else
            {
                lblIdleNextBonus.text = "+" + (Math.calculate_NextBonus(idlerBaseBonus, idlerCount + 1, idlerMult * upgradeIdlerBonus > 0 ? upgradeIdlerBonus : 1) - idlerBonus).ToString("N2") + " $/s";
            }
            lblIdleCost.text = idlerCost.ToString("N2") + " $";
            if (game.totalMoney >= idlerCost)
            {
                lblIdleCost.color = Color.green;
            }
            else
            {
                lblIdleCost.color = Color.red;
            }
            //Idler Upgrade
            if (upgradeIdlerTier == 0)
            {
                lblIdlerUpgradeNextBonus.text = "x" + (Math.calculate_NextBonus(upgradeIdlerBaseBonus, 1, 1 )).ToString("N2");
            }
            else
            {
                lblIdlerUpgradeNextBonus.text = "x" + Math.calculate_NextBonus(upgradeIdlerBaseBonus, upgradeIdlerTier+1, 1).ToString("N2");
            }
            lblIdlerUpgradeCost.text = upgradeIdlerCost.ToString("N2") + " $";

            if (game.totalMoney >= upgradeIdlerCost)
            {
                lblIdlerUpgradeCost.color = Color.green;
            }
            else
            {
                lblIdlerUpgradeCost.color = Color.red;
            }



            idlerBonus = Math.calculate_NextBonus(idlerBaseBonus, idlerCount, idlerMult * upgradeIdlerBonus > 0 ? upgradeIdlerBonus : 1);
        }
        public void Click_AddIdler()
        {
            if (game.totalMoney >= idlerCost)
            {
                game.SubMoney(idlerCost);
                idlerCount++;
                
                if (idlerCount == 0)
                {
                    idlerMult = 1;
                }
                else if (idlerCount < 101 && idlerCount % 25 == 0)
                {
                    idlerMult *= 2;
                }
                else if (idlerCount > 100 && idlerCount % 100 == 0)
                {
                    idlerMult *= 2;
                }
                idlerCost = Math.calculate_NextCost(idlerBaseCost, idlerGrowth, idlerCount);
            }
        }
        public void Click_UpgradeIdler()
        {
            if (game.totalMoney >= upgradeIdlerCost)
            {
                game.SubMoney(upgradeIdlerCost);
                upgradeIdlerTier++;
                upgradeIdlerCost = Math.calculate_NextCost(upgradeIdlerBaseCost, upgradeidlerGrowth, upgradeIdlerTier);
                upgradeIdlerBonus = Math.calculate_NextBonus(upgradeIdlerBaseBonus, upgradeIdlerTier, 1);

            }
        }


    }
}