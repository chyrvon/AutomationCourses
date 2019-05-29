using System;

namespace HW6
{
    class SimpleGarland : Garland
    {
        public SimpleGarland(int garlandLength) : base(garlandLength)
        {
            for (int i = 0; i < garlandLength; i++)
            {
                _garland[i] = new Lamp(i);
            }
        }

        public override void ShowStatusGarland(bool currentEvenMinute)
        {
            Console.WriteLine("Simple garland status:");
            PrintTaskPage.StringToPrn += $"\nSimple garland status:\n";
            foreach (Lamp i in _garland)
            {
                new ConsoleChangeColor(i.GetStatusLamp(currentEvenMinute), "Yellow");
                Console.WriteLine($"{i.IndexNumber + 1} lamp is {i.GetStatusLamp(currentEvenMinute)}");
                PrintTaskPage.StringToPrn += $"{i.IndexNumber + 1} lamp is {i.GetStatusLamp(currentEvenMinute)}\n";
            }
            Console.ResetColor();
        }
        
    }
}


