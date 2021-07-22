using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*
 * Inventory Class:
 * Stores Items type object in a list
 * List index == item ID
 * 
 * **/
namespace TheIdleGame
{
    public class Inventory : MonoBehaviour
    {
        public List<Items> inv;

        public Inventory()
        {
           inv = new List<Items>();   
        }
        public void AddNewItem(Items item)
        {
            inv[item.ID] = item;
        }
        public void RemoveNewItem(Items item)
        {
            inv.Remove(item);
        }
        public double GetItemQuantity(int itemID, double qty)
        {
            return inv[itemID].quantityOwned;
        }

        public void AddItemQuantity(int itemID, double qty)
        {
            inv[itemID].quantityOwned += qty;
        }        
        public void RemoveItemQuantity(int itemID, double qty)
        {
            inv[itemID].quantityOwned += qty;
            if (inv[itemID].quantityOwned < 0)
            {
                inv[itemID].quantityOwned = 0;
            }
        }
    }
}

