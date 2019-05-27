using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public class Lamp
    {
        public int IndexNumber { get; set; }

        public Lamp(int indexNumber)
        {
            IndexNumber = indexNumber;
        }

        public string GetStatusLamp(bool currentEvenMinute)
        {

            if (IndexNumber % 2 == 0 ^ currentEvenMinute)
            {
                return "On";
            }
            else
            {
                return "Off";
            }
        }
    }
}
