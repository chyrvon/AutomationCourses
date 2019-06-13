using System;
using HW6.enam;
namespace HW6
{
    public class ColorGarland : Garland<ColorLamp>
    {
        private int numberOfColors = Enum.GetValues(typeof(ColorMy)).Length;

        public ColorGarland(int garlandLength) : base(garlandLength)
        {
            for (int i = 1; i <= numberOfColors; i++)
            {
                ColorMy color = (ColorMy)i;
                for (int j = i - 1; j < garlandLength; j = j + numberOfColors)
                {
                    _garland[j] = new ColorLamp(j, color.ToString());
                }
            }
        }

        public override void ShowStatusGarland()
        {
            bool сurrentMinuteEvenOrOdd = GetCurrentMinutes.EvenOrOdd();
            Console.WriteLine("Colored garland status:");
            PrintTaskPage.StringToPrint += $"\nColored garland status:\n";
            foreach (ColorLamp item in _garland)
            {
                new ConsoleChangeColor(item.GetStatusLamp(сurrentMinuteEvenOrOdd), item.ColorsLamp);
                string stringToShow = $"{item.IndexNumber + 1} lamp is {item.ColorsLamp} and {item.GetStatusLamp(сurrentMinuteEvenOrOdd)}";
                Console.WriteLine(stringToShow);
                Console.ResetColor();
                PrintTaskPage.StringToPrint += stringToShow;
            }
        }
    }
}
