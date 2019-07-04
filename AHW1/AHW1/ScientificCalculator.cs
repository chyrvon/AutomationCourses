using System;
using System.Linq;

namespace AHW1
{
    public class ScientificCalculator : Calculator
    {
        public double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public double Percents(double number, double persent)
        {
            return number / 100 * persent;
        }
        public int Mod(int a, int b)
        {
            return (Math.Abs(a * b) + a) % b;
        }

        public int sumOfArray(int [] array)
        {
            return array.Sum();
        }

        public double minOfArray(int[] array)
        {
            return array.Min();
        }

        public double maxOfArray(int[] array)
        {
            return array.Max();
        }
    }
}
