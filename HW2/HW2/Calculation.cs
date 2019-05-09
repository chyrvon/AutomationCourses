using System;
namespace CustomMethods
{
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
                Console.Write("The entered value is not valid, enter integer > 0: ");
                goto RetryEnterLengthSide;
            }
            return Value;
        }
        public static double CompareArea(int LenSide, int RCircle)
        {
            double ValueReturn = 0;
            if (RCircle >= LenSide / 2)
                return ValueReturn = 1;
            if (Math.Sqrt(LenSide.AreaOfSquare()) > 2 * Math.Sqrt(RCircle.AreaOfCircle() / Constants.Pi))
                return ValueReturn = 2;
            return ValueReturn;
        }
        public static double AreaOfSquare(this int LenSide)
        {
            return Math.Pow(LenSide, 2);
        }
        public static double AreaOfCircle(this int RCircle)
        {
            return Constants.Pi * Math.Pow(RCircle, 2);
        }
    }
}
