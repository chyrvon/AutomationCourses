using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Square
    {
        private double _side;
        public double Side
        {
            set
            {
                if (value <= 0)
                {
                    _side = Constants.defaultValue;
                    Console.WriteLine($"{value} is not valid. Set default value: {_side}");
                }
                else
                {
                    _side = value;
                }
            }
            get
            {
                return _side;
            }
        }

        public Square()
        {
            Side = new GetValue().ReadValueConsole("Enter the length of the side of the Square: ");
        }

        public double AreaOfSquare(double side)
        {
            Side = side;
            return Math.Round(Math.Pow(Side, 2), 2);
        }
    }
}
