using System;

namespace AHW1.Helper
{
    public class GetValueConsole
    {
        public int ReadIntValueFromConsole(string strMessage)
        {
            int enterValue = 0;
            Console.Write(strMessage);
            int.TryParse(Console.ReadLine(), out enterValue);
            return enterValue;
        }
    }
}
