using System;

namespace HW6
{
    public class GetValue
    {
        public int ReadValueConsoleToMenu()
        {
            int value;
            for (int i = 1; i <= UserMenu.ReTry; i++)
            {
                int.TryParse(Console.ReadLine(), out value);
                if ((value < 1 || value > 7) && i != UserMenu.ReTry)
                {
                    Console.WriteLine($"Input value is incorrect. Attempts left {UserMenu.ReTry - i}. Please, try again: ");
                }
                else
                {
                    return value;
                }
            }
            return 0;
        }

        public int ReadValueConsoleInt()
        {
            int value;
            for (int i = 1; i <= UserMenu.ReTry; i++)
            {
                int.TryParse(Console.ReadLine(), out value);
                if ((1 > value || value > 1000) && i != UserMenu.ReTry)
                {
                    Console.WriteLine($"Input value is incorrect (1-1000). Attempts left {UserMenu.ReTry - i}. Please, try again: ");
                }
                else
                {
                    return value;
                }
            }
            return 0;
        }
    }
}
