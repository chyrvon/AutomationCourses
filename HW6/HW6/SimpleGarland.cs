using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class SimpleGarland : Garland
    {
        public SimpleGarland(int garlandLenght) : base(garlandLenght)
        {
            for (int i = 0; i < garlandLenght; i++)
            {
                _garland[i] = new Lamp(i);
            }
        }

        public void PrintStatusGarland(bool currentEvenMinute)
        {
            Console.WriteLine("Status simple garland:");
            foreach (Lamp i in _garland)
            {
                if (i.GetStatusLamp(currentEvenMinute) == "On")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else Console.ForegroundColor = ConsoleColor.DarkGray;
                

                Console.WriteLine($"{i.IndexNumber + 1} lamp is {i.GetStatusLamp(currentEvenMinute)}");
            }
        }
        
    }
}


