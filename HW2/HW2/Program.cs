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
            Console.WriteLine($"Area of a Square: {square1.AreaOfSquare(square1.Side)}");
            Console.WriteLine($"Area of a Circle: {circle1.AreaOfCircle(circle1.Radius)}");
            new Сalculation().CompareArea(square1.Side, circle1.Radius);
            Console.ReadKey();
        }
    }
}
