using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW4
{
    public class GetValue
    {
        public string ReadValueConsole(string strMessage)
        {
            Console.Write(strMessage);
            string enterValueString = Console.ReadLine();
            Regex dictionaryChars = new Regex("^[a-zA-Zа-яА-Я0-9]*$");
            enterValueString = enterValueString.Replace(" ", "");

            if (enterValueString.Length > 5)
            {
                if (!dictionaryChars.IsMatch(enterValueString))
                {
                    Console.WriteLine("Special characters are not supported. Try again!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Word is short. Try again!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return enterValueString;
        }
    }
}

