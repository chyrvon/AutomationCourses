using CustomFiles;
using System;

namespace HW_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the side of the Square: ");
            double ValueSSquare = Convert.ToInt32(Console.ReadLine()).SSquare();

            Console.Write("Enter the radius of the Circle: ");
            double ValueSCircle = Convert.ToInt32(Console.ReadLine()).SCircle();

            Console.WriteLine($"Area of a Square: {ValueSSquare} Area of a Circle: {ValueSCircle}");
            Console.ReadKey();
        }
    }
}