using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Сalculation
    {
         public int CompareArea(double side, double rCircle)
        {
            int valueReturn = 0;
            if (rCircle <= side / 2) 
            {
                Console.Write("The circle is fit in the square");
                return valueReturn = 1;
            }
            if (rCircle >= side * (Math.Sqrt(2) / 2))
            {
                Console.Write("The square is fit in a circle");
                return valueReturn = 2;
            }
            Console.Write("Figures intersect");
            return valueReturn;
        }
    }
}
