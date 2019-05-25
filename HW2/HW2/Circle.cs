using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Circle
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value <= 0)
                {
                    _radius = Constants.defaultValue;
                    Console.WriteLine($"{value} is not valid. Set default value: {_radius}");
                }
                else
                {
                    _radius = value;
                }
            }
        }

        public Circle()
        {
            Radius = new GetValue().ReadValueConsole("Enter the radius of the Circle: ");
        }

        public double AreaOfCircle(double radius)
        {
            Radius = radius;
            return Math.Round(Constants.Pi * Math.Pow(Radius, 2), 2);
        }
    }
}
