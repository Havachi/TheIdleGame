using UnityEngine;
using UnityEngine.UI;

namespace TheIdleGame
{
    public class Upgrade : MonoBehaviour
    {
        private Game game;

        public Canvas canvas;
        //Clicker Upgrade Lables
        public Text lblClickerNextBonus;
        public Text lblClickerUpgradeCost;
        //Clicker Upgrade
        public double upgradeClickerTier;
        public double upgradeClickerBonus;
        public double upgradeClickerCost;

        // Start is called before the first frame update
        void Start()
        {
            //Clicker Upgrade
            upgradeClickerTier = 0;
            upgradeClickerBonus = 1;
            upgradeClickerCost = 50;

            game = GetComponentInParent<Game>();
        }

        // Update is called once per frame
        void Update()
        {
            //Clicker Upgrade
            lblClickerNextBonus.text = "+" + upgradeClickerBonus.ToString("N2") + " $/click";
            lblClickerUpgradeCost.text = upgradeClickerCost.ToString("N2") + " $";
            if (game.totalMoney > upgradeClickerCost)
            {
                lblClickerUpgradeCost.color = Color.green;
            }
            else
            {
                lblClickerUpgradeCost.color = Color.red;
            }
        }


        public void Click_UpgradeClicker()
        {

            if (game.totalMoney >= upgradeClickerCost)
            {
                game.SubMoney(upgradeClickerCost);
                game.clicker.moneyPerClick += upgradeClickerBonus;
                upgradeClickerBonus *= 1.5;
                upgradeClickerCost *= 1.07;
            }
        }
    }
}