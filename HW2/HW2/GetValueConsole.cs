using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class GetValue
    {
        public double ReadValueConsole(string strMessage)
        {
            double value = 0;
            Console.Write(strMessage);
            for (int _reTry = 1; _reTry <= Constants.ReTry; _reTry++)
            {
                double.TryParse(Console.ReadLine(), out value);
                if (value <= 0 && _reTry < Constants.ReTry)
                {
                    Console.Write($"The entered value is not valid. "
                        + $"Attempts left: {Constants.ReTry - _reTry}. Try again: ");
                }
                else
                {
                    break;
                }
            }
            return Math.Round(value, 2);
        }
    }
}
