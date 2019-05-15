using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Сalculation
    {
        public Сalculation()
        {
        }

        public int EnterValue(string strMessage)
        {
            int value = 0;
            Console.Write(strMessage);
            for (int retry = 1; retry < 4; retry++)
            {
                int.TryParse(Console.ReadLine(), out value);
                if (value <= 0)
                {
                    if (retry != 3)
                    {
                        Console.Write($"The entered value is not valid. Attempts left: {3 - retry}. Try again.\nEnter an integer in the range 0-32767: ");
                    }
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
    }
}
