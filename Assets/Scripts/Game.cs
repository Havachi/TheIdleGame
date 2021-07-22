using UnityEngine;
using UnityEngine.UI;

/* Game Class:
 * 
 * This class contain
 * 
 * 
 * 
 * 
 * **/

namespace TheIdleGame
{
    public class Game : MonoBehaviour
    {
        //Sub Manager
        public Clicker clicker;
        public Upgrade upgrade;
        public Idler idler;

        public Inventory inventory;

        //Money, $/s Labels
        public Text lblMoney;
        public Text lblMoneyPerSecond;

        //Money
        public double totalMoney;
        public double moneyPerSecond;
        public double moneyPerClick;

        public void Start()
        {
            clicker.canvas.enabled = true;
            upgrade.canvas.enabled = false;
            idler.canvas.enabled = false;
        }

        public void Update()
        {
            //Money
            lblMoney.text = "Money: " + totalMoney.ToString("N2");
            lblMoneyPerSecond.text = "+" + moneyPerSecond.ToString("N2") + " $/s";

            //$PS
            moneyPerSecond = idler.idlerBonus;
            totalMoney += moneyPerSecond * Time.deltaTime;
        }



        public void AddMoney(double qty)
        {
            totalMoney += qty;
        }
        public void SubMoney(double qty)
        {
            totalMoney -= qty;
        }
    }
}