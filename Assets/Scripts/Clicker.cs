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
        private Text lblAddMoney;

        public double moneyPerClick;
        public double totalClick;
        // Start is called before the first frame update
        void Start()
        {
            game = GetComponentInParent<Game>();
            moneyPerClick = 1;
        }

        // Update is called once per frame
        void Update()
        {
            //Clicker Button
            lblAddMoney.text = "+" + moneyPerClick.ToString("N2") + " $";
        }
        public void Click_Clicker()
        {
            Game game = this.GetComponentInParent<Game>();
            game.AddMoney(moneyPerClick);
            totalClick++;
        }
    }
}