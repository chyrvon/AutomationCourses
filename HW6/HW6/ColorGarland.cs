using System;

namespace HW6
{
    public class ColorGarland : Garland
    {
        public ColorLamp[] Garlands;
        private int numberOfColors = Enum.GetValues(typeof(ColorMy)).Length;

        public ColorGarland(int garlandLength) : base(garlandLength)
        {
            Garlands = new ColorLamp[garlandLength];

            for (int i = 1; i <= numberOfColors; i++)
            {
                ColorMy color = (ColorMy)i;

                for (int j = i - 1; j < garlandLength; j = j + numberOfColors)
                {
                    Garlands[j] = new ColorLamp(j, color.ToString());
                }
            }
        }

        public override void ShowStatusGarland(bool currentEvenMinute)
        {
            Console.WriteLine("Colored garland status:");
            PrintTaskPage.StringToPrn += $"\nColored garland status:\n";
            foreach (ColorLamp item in Garlands)
            {
                new ConsoleChangeColor(item.GetStatusLamp(currentEvenMinute), item.ColorsLamp);
                Console.WriteLine($"{item.IndexNumber + 1} lamp is {item.ColorsLamp} and {item.GetStatusLamp(currentEvenMinute)}");
                Console.ResetColor();
                PrintTaskPage.StringToPrn += $"{item.IndexNumber + 1} lamp is {item.ColorsLamp} and {item.GetStatusLamp(currentEvenMinute)}\n";
            }
        }

    }
}
