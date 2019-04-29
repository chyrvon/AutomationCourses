using System;

namespace CustomMethods
{
    static class Constants
    {
        public const double Pi = 3.14159;
    }
    
    public static class Сalculation
    {
        public static int EnterValue(string StrMessage)
        {
            int Value;
            Console.Write(StrMessage);
        RetryEnterLengthSide:
            try
            {
                Value = Convert.ToInt32(Console.ReadLine());
                if (Value <= 0) throw new NullReferenceException();
            }
            catch
            {
                Console.Write("Введено не валидное значение, введите целое число больше 0: ");
                goto RetryEnterLengthSide;
            }
            return Value;
        }
        public static double CompareS(int LenSide, int RCircle)
        {
            double ValueReturns = 0;
            if (RCircle >= LenSide/2) return ValueReturns = 1;
            if (Math.Sqrt(LenSide.SSquare()) > 2 * Math.Sqrt(RCircle.SSquare()/ Constants.Pi)) return ValueReturns = 2;
            return ValueReturns;
        }
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

namespace HW_Task2
{
    using CustomMethods;
    class Program
    {
        static void Main(string[] args)
        {
            int LengthSide = Сalculation.EnterValue("Введите длинну стороны квадрата: ");
            int Radius = Сalculation.EnterValue("Введите радиус круга: ");
            Console.WriteLine($"Площадь квадрата: {LengthSide.SSquare()} Площадь круга: {Radius.SCircle()}");
            switch (Сalculation.CompareS(LengthSide, Radius))
            {
                case 0:
                    Console.Write("Квадрат не вписан в круг.\n ValueReturns = 0");
                    break;
                case 1:
                    Console.Write("Круг расположен в квадрате");
                    break;
                case 2:
                    Console.Write("Квадрат расположен в круге");
                    break;
            }
            Console.ReadKey();
        }
    }
}


    