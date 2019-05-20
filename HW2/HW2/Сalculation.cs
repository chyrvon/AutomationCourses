using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Сalculation
    {
        public int EnterValue(string strMessage)
        {
            int value = 0;
            Console.Write(strMessage);
            for (int retry = 1; retry < 4; retry++)
            {
                int.TryParse(Console.ReadLine(), out value);
                if (value <= 0 && retry != 3)
                {
                        Console.Write($"The entered value is not valid. Attempts left: {3 - retry}. Try again.\nEnter an integer in the range 0-32767: ");
                }
                else
                {
                    return value;
                }
            }
            Console.Write("\nTry out. Default value: 5\n");

            value = 5;
            return value;
        }
        public double CompareArea(int side, int rCircle)
        {
            double valueReturn = 0;
            if (rCircle <= side / 2) 
            {
                return valueReturn = 1;
            }
            if (rCircle >= side * (Math.Sqrt(2) / 2))
            {
                return valueReturn = 2;
            }
            return valueReturn;
        }
    }
}
