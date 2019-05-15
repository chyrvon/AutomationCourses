using System;
using HW1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square();
            Circle circle1 = new Circle();

            Console.WriteLine($"Area of a Square: {square1.AreaOfSquare()} \nArea of a Circle: {Math.Round(circle1.AreaOfCircle(), 2)}");
            Сalculation calc = new Сalculation();

            Console.ReadKey();
        }
    }
}
