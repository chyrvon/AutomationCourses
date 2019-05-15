using System;
using HW2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square();
            Circle circle1 = new Circle();

            Console.WriteLine($"Area of a Square: {square1.AreaOfSquare()} \nArea of a Circle: {Math.Round(circle1.AreaOfCircle(), 2)}");
            Сalculation calc = new Сalculation();

            switch (calc.CompareArea(square1.Side, circle1.Radius))
            {
                case 0:
                    Console.Write("Figures intersect");
                    break;
                case 1:
                    Console.Write("The circle is fit in the square");
                    break;
                case 2:
                    Console.Write("The square is fit in a circle");
                    break;
            }
            Console.ReadKey();
        }
    }
}
