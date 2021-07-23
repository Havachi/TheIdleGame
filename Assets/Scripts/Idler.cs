using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TheIdleGame
{
    public class Idler : MonoBehaviour
    {
        private Game game;
        public Canvas canvas;
        public List<Button> idlerBtns;
        public List<Generator> genType;
        // Start is called before the first frame update
        void Start()
        {
            
            game = GetComponentInParent<Game>();
            Generator gen = new Generator();
            
            //Idler

        }
    
        // Update is called once per frame
        void Update()
        {
            if(idlerBtns.Count > 0)
            {
                List<Text> lbl = new List<Text>();
                for (int i = 0; i < idlerBtns.Count; i++)
                {
                    Text lblGeneratorTitle = (Text)idlerBtns[i].transform.GetChild(0).gameObject.GetComponent(typeof(Text));
                    Text lblGeneratorProd = (Text)idlerBtns[i].transform.GetChild(0).gameObject.GetComponent(typeof(Text));
                }
            }
         /*   
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
        */
        }
        public void Click_AddIdler()
        {
            /*
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
            */
        }
        public void Click_UpgradeIdler()
        {
            /*
            if (game.totalMoney >= upgradeIdlerCost)
            {
                game.SubMoney(upgradeIdlerCost);
                upgradeIdlerTier++;
                upgradeIdlerCost = Math.calculate_NextCost(upgradeIdlerBaseCost, upgradeidlerGrowth, upgradeIdlerTier);
                upgradeIdlerBonus = Math.calculate_NextBonus(upgradeIdlerBaseBonus, upgradeIdlerTier, 1);

            }
            */
        }


    }
}