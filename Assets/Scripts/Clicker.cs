using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TheIdleGame
{
    public class Clicker : MonoBehaviour
    {
        private Game game;
        //Canvas
        public Canvas canvas;
        //Clicker Labels
        

        public List<Button> clickerBtns;

        double woodClickerProd = 1;
        public double totalClick;
        // Start is called before the first frame update
        void Start()
        {
            clickerBtns[0].gameObject.SetActive(true);
            clickerBtns[1].gameObject.SetActive(false);

            game = GetComponentInParent<Game>();
            
        }

        // Update is called once per frame
        void Update()
        {       
            for (int i = 0; i < clickerBtns.Count; i++)
            {
               Text lblName =  (Text)clickerBtns[i].transform.GetChild(0).gameObject.GetComponent(typeof(Text));
               Text lblProd =  (Text)clickerBtns[i].transform.GetChild(1).gameObject.GetComponent(typeof(Text));
               lblName.text = clickerTexts.GetClickerTitle(i);
               lblProd.text = clickerTexts.GetClickerProdPrefix(i) + woodClickerProd + clickerTexts.GetClickerProdSuffix(i);
            }
        }
       
        public void Click_Wood()
        {
            game.qtyWood++;
            totalClick++;
        }
    }
}