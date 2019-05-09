using System;
namespace HW_Task2
{
    using CustomMethods;
    class Program
    {
        static void Main(string[] args)
        {
            int LengthSide = Сalculation.EnterValue("Enter the length of the side of the Square: ");
            int Radius = Сalculation.EnterValue("Enter the radius of the Circle: ");
            Console.WriteLine($"Area of a Square: {LengthSide.AreaOfSquare()} Area of a Circle: {Radius.AreaOfCircle()}");
            switch (Сalculation.CompareArea(LengthSide, Radius))
            {
                case 0:
                    Console.Write("The square isn't located in the circle.\n ValueReturns = 0");
                    break;
                case 1:
                    Console.Write("The circle is located in the square");
                    break;
                case 2:
                    Console.Write("The square is located in a circle");
                    break;
            }
            Console.ReadKey();
        }
    }
}