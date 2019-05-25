using System;

namespace HW2
{
    class Square
    {
        private double _side;
        public double Side
        {
            get
            {
                return _side;
            }
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
