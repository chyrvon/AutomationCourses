using System;
using HW6.enam;
namespace HW6.Helper
{
    public class GetValue
    {
        public static int ReadValueConsoleToMenu(int maxValue = 4)
        {
            int value = 0;
            for (int i = 1; i <= UserMenu.ReTry; i++)
            {
                int.TryParse(Console.ReadLine(), out value);
                if ((value < 1 || value > maxValue) && i != UserMenu.ReTry)
                {
                    Console.WriteLine($"Input value is incorrect (1-{maxValue}). Attempts left {UserMenu.ReTry - i}. Please, try again: ");
                }
                else
                {
                    return value;
                }
            }
            return value;
        }

        public static string ReadValueConsoleColor()
        {
            ColorMy result;
            for (int _reTry = 1; _reTry <= UserMenu.ReTry; _reTry++)
            {
                if (Enum.TryParse(Console.ReadLine(), true, out result) && Enum.IsDefined(typeof(ColorMy), result))
                {
                    return result.ToString();
                }
                else
                {
                    if (_reTry != UserMenu.ReTry)
                    {
                        Console.Write($"The entered value is not valid. "
                        + $"Attempts left: {UserMenu.ReTry - _reTry}. Try again: ");
                    }
                    else
                    {
                        Enum.TryParse(3.ToString(), out result);
                        Console.WriteLine($"Set default value: {result.ToString()}");
                    }
                }
            }
            Enum.TryParse(3.ToString(), out result);
            return result.ToString();
        }
    }
}
