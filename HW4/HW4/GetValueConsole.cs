using System;
using System.Text.RegularExpressions;

namespace HW4
{
    public class GetValue
    {
        public string ReadValueConsole(string strMessage)
        {
            Console.Write(strMessage);
            string enterValueString = Console.ReadLine();
            Regex dictionaryChars = new Regex("^[a-zA-Zа-яА-Я]*$");
            if (!dictionaryChars.IsMatch(enterValueString))
            {
                Console.WriteLine("Only letters permitted. Try again!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return enterValueString;
        }
    }
}

