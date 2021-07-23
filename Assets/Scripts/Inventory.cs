using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



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
        public GameObject scollContent;
        private GameObject defaultItem;
        private void Start()
        {
            inv = new List<Items>();
            inv.Add(new Materials(0, "wood"));
            inv.Add(new Materials(1, "leaves"));
            defaultItem = scollContent.transform.GetChild(0).gameObject;          
            

        }
        private void Update()
        {
            //TODO: Inventory display not updating
            defaultItem.SetActive(false);
            int test = inv.Count;
            if (inv.Count > 0)
            {

                for (int i = 0; i < inv.Count; i++)
                {
                    if (inv[i] != null)
                    {
                        GameObject tmp = defaultItem.gameObject;
                        Text lblName = (Text)tmp.transform.GetChild(0).gameObject.GetComponent(typeof(Text));
                        Text lblQuantity = (Text)tmp.transform.GetChild(1).gameObject.GetComponent(typeof(Text));
                        Text lblPCs = (Text)tmp.transform.GetChild(2).gameObject.GetComponent(typeof(Text));

                        lblName.text = inv[i].name;
                        lblQuantity.text = GetItemQuantity(i).ToString();
                        lblPCs.text = inv[i].PCs;

                        tmp.transform.GetChild(0).gameObject.GetComponents(typeof(Text))[0] = lblName;
                        tmp.transform.GetChild(1).gameObject.GetComponents(typeof(Text))[0] = lblQuantity;
                        tmp.transform.GetChild(2).gameObject.GetComponents(typeof(Text))[0] = lblPCs;
                        tmp.SetActive(true);
                        
                        tmp.transform.SetParent(scollContent.transform);
                        tmp.transform.localPosition = new Vector3(tmp.transform.localPosition.x, tmp.transform.localPosition.y, tmp.transform.localPosition.z); 
                    }

                }
            }
        }
        public void AddNewItem(Items item)
        {         
            inv.Add(item);
        }
        public void RemoveItem(Items item)
        {
            inv.Remove(item);
        }
        public double GetItemQuantity(int itemID)
        {
            return GetItemByID(itemID).quantityOwned;
        }
        public int GetPosByID(int itemID)
        {
            int i = 0;
            foreach(Items aitem in inv)
            {
                if(aitem.ID == itemID)
                {
                    return i;
                }
                i++;
            }
            return -1;
                
        }
        public Items GetItemByID(int ID)
        {
            foreach (Items item in inv)
            {
                if(item.ID == ID)
                {
                    return item;
                }
            }
            return null;
        }
        public int GetPosByName(string name)
        {
            int i = 0;
            foreach (Items item in inv)
            {
                if (item.name == name)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public void AddItemQuantity(int itemID, double qty)
        {
            inv[GetPosByID(itemID)].quantityOwned += qty;
        }        
        public void RemoveItemQuantity(int itemID, double qty)
        {
            inv[itemID].quantityOwned += qty;
            if (inv[itemID].quantityOwned < 0)
            {
                inv[itemID].quantityOwned = 0;
            }
        }
        public void updateInventory()
        {

        }
        private bool contains(int itemID)
        {
            if(inv.Contains(GetItemByID(itemID)))
            {
                return true;
            }
            return false;
        }
    }
}

