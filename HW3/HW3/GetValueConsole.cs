using System;

namespace HW3
{
    public class GetValue
    {
        public int ReadValueConsole(string strMessage)
        {
            int value;
            Console.Write(strMessage);
            for (int _reTry = 1; _reTry <= Constants.ReTry; _reTry++)
            {
                int.TryParse(Console.ReadLine(), out value);
                if ((value <= 0 || value < Constants.MinValueNumber) && _reTry < Constants.ReTry)
                {
                    Console.Write($"The entered value is not valid. "
                        + $"Attempts left: {Constants.ReTry - _reTry}. Try again: ");
                }
                else
                {
                    if (_reTry != Constants.ReTry)
                    {
                        return value;
                    }
                }
            }
            value = new Random().Next(Constants.MinValueNumber, 40);
            Console.Write($"\nAutocomplete number to array: {value}\n");
            Console.ReadLine();
            return value;
        }
    }
}
