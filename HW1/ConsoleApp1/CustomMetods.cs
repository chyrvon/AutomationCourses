using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFiles
{
    public static class Сalculation
    {
        public static double SSquare(this int LenSide)
        {
            return Math.Pow(LenSide, 2);
        }

        public static double SCircle(this int RCircle)
        {
            return Constants.Pi * Math.Pow(RCircle, 2);
        }
    }
}
