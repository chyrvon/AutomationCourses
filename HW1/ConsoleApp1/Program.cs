using System;

namespace CustomMethods
{
    static class Constants
    {
        public const double Pi = 3.14159;
    }

    public static class Сalculation
    {
        public static double SSquare(this int LenSide)
        {
            return Math.Pow(LenSide, 2);
        }
                   
        public static double SCircle(this int RCircle)
        {
            return Constants.Pi * Math.Pow(RCircle, 2);
        }
    }
}

namespace HW_Task1
{
    using CustomMethods;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну стороны квадрата: ");
            double ValueSSquare = Convert.ToInt32(Console.ReadLine()).SSquare();

            Console.Write("Введите радиус круга: ");
            double ValueSCircle = Convert.ToInt32(Console.ReadLine()).SCircle();

            Console.WriteLine($"Площадь квадрата: {ValueSSquare} Площадь круга: {ValueSCircle}");
            Console.ReadKey();
        }
    }
}