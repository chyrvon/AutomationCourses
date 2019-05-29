using System;

namespace HW6
{
    class ConsoleChangeColor
    {
        public ConsoleChangeColor (string statusLamp, string colorsLamp)
        {
            if (statusLamp == "On")
            {
                switch (colorsLamp)
                {
                    case "Red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "Yellow":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case "Green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "Blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    default:
                        Console.ResetColor();
                        break;
                }
            }
            else
            {
                Console.ResetColor();
            }
        }
    }
}
