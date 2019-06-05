using System;
namespace HW5.Helper
{
    public class GetValue
    {
        public int ReadValueConsole(string strMessage)
        {
            int value = 0;
            Console.Write(strMessage);
            for (int _reTry = 1; _reTry <= Constants.ReTry; _reTry++)
            {
                int.TryParse(Console.ReadLine(), out value);
                if (value <= 0 && _reTry < Constants.ReTry)
                {
                    Console.Write($"The entered value is not valid. "
                        + $"Attempts left: {Constants.ReTry - _reTry}. Try again: ");
                }
                else
                {
                    return value;
                }
            }
            return value;
        }
    }
}