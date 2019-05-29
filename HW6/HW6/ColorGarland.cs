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
            foreach (ColorLamp i in Garlands)
            {
                new ConsoleChangeColor(i.GetStatusLamp(currentEvenMinute), i.ColorsLamp);
                Console.WriteLine($"{i.IndexNumber + 1} lamp is {i.ColorsLamp} and {i.GetStatusLamp(currentEvenMinute)}");
                Console.ResetColor();
                PrintTaskPage.StringToPrn += $"{i.IndexNumber + 1} lamp is {i.ColorsLamp} and {i.GetStatusLamp(currentEvenMinute)}\n";
            }
        }

    }
}
