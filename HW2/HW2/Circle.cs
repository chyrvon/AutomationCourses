using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Circle
    {
        public int Radius { get; set; }
        public double Square { get; set; }
        public Circle()
        {
            Radius = new Сalculation().EnterValue("Enter the radius of the Circle: ");
        }

        public double AreaOfCircle()
        {
            Square = Constants.Pi * Math.Pow(Radius, 2);
            return Square;
        }
    }
}
