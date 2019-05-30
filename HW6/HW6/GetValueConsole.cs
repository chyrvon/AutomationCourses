using System;

namespace HW6
{
    public class GetValue
    {
        public int ReadValueConsoleToMenu(int maxValue = 4)
        {
            int value;
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
            return 0;
        }

        public string ReadValueConsoleColor()
        {
            //ColorMy result2 = ColorMy.Red;
            //Enum.TryParse(Console.ReadLine(), true, out result2);
            //result2.ToString();

            ColorMy result;
            string value = Console.ReadLine();
            Enum.TryParse(value, true, out result);
            switch (result)
            {
                case ColorMy.Red:
                    value = ColorMy.Red.ToString();
                    break;
                case ColorMy.Yellow:
                    value = ColorMy.Yellow.ToString();
                    break;
                case ColorMy.Green:
                    value = ColorMy.Green.ToString();
                    break;
                case ColorMy.Blue:
                    value = ColorMy.Blue.ToString();
                    break;
                default:
                    value = ColorMy.Red.ToString();
                    break;
            }
            return value;
        }
    }
}
