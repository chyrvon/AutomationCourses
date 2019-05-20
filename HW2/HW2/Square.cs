using System;

namespace HW2
{
   public class Square
    {
        public int Side { get; set; }
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
