using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Circle
    {
        public int Radius;
        public Circle()
        {
            Radius = new Сalculation().EnterValue("Enter the radius of the Circle: ");
        }

        public double AreaOfCircle()
        {
            return Constants.Pi * Math.Pow(Radius, 2);
        }
    }
}
