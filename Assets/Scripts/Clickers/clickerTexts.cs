using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIdleGame
{
    static class clickerTexts
    {
        static string woodClickerTitle = "Chop Wood";
        static string woodClickerProdPrefix = "+ ";
        static string woodClickerProdSuffix = " wood";

        static string leaveClickerTitle = "Gather Leave";
        static string leaveClickerProdPrefix = "+ ";
        static string leaveClickerProdSuffix = " leave";
        static public string GetClickerTitle(int clickerType)
        {
            switch (clickerType)
            {
                case 0:
                    return woodClickerTitle;
                case 1:
                    return leaveClickerTitle;
                default:
                    return "";         
            }

        }
        static public string GetClickerProdPrefix(int clickerType)
        {
            switch (clickerType)
            {
                case 0:
                    return woodClickerProdPrefix;
                case 1:
                    return leaveClickerProdPrefix;
                default:
                    return "";
            }
        }
        static public string GetClickerProdSuffix(int clickerType)
        {
            switch (clickerType)
            {
                case 0:
                    return woodClickerProdSuffix;
                case 1:
                    return leaveClickerProdSuffix;
                default:
                    return "";
            }
        }
    }
}
