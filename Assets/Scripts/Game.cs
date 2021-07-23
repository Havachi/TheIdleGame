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

        //Materials
        public double qtyWood;



        public void Start()
        {
            clicker.canvas.enabled = true;
            upgrade.canvas.enabled = false;
            idler.canvas.enabled = false;            

        }

        public void Update()
        {
            //$PS
            //moneyPerSecond = idler.idlerBonus;
            //totalMoney += moneyPerSecond * Time.deltaTime;
            inventory.inv[0].quantityOwned = qtyWood;
        }

        
    }
}