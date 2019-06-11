using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace HW7.Helper
{
    public class PrintHelper
    {
        public static string StringToPrint;
        private string PrintString;

        public PrintHelper()
        {
            PrintString = StringToPrint;
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);
            printDocument.Print();
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs page)
        {
            page.Graphics.DrawString(PrintString, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        public static void DisplayCountries(DictionaryCountries dictionaryCountries, bool isTelenorSupport = false)
        {
            StringToPrint += $"\nIsTelenorSupported = {isTelenorSupport} for: \n";
            int i = 1;
            string stringShown;
            Console.Clear();
            foreach (KeyValuePair<int, Country> keyValue in dictionaryCountries.countries)
            {
                if (keyValue.Value.IsTelenorSupported == isTelenorSupport)
                {
                    stringShown = $"{i++}. {keyValue.Value.Name} - {keyValue.Value.IsTelenorSupported}\n";
                    Console.Write(stringShown);
                    StringToPrint += stringShown;
                }
            }
        }
    }
}
