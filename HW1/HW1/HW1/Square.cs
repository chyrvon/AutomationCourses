using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Square
    {
        public int Side;
        public Square()
        {
            Side = new Сalculation().EnterValue("Enter the length of the side of the Square: ");
        }

        public double AreaOfSquare()
        {
            return Math.Pow(Side, 2);
        }
    }
}
