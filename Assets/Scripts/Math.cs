using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIdleGame
{
    static class Math
    {
        static private double Pow(double x, double y)
        {
            return System.Math.Pow(x, y);
        }

        static public double calculate_NextCost(double baseCost, double growthRate, double count)
        {
            return baseCost * Pow(growthRate, count);
        }
        static public double calculate_NextBonus(double baseBonus, double count, double mult)
        {
            return baseBonus * count * mult;
        }
    }
}
