using System;
using System.Drawing;
using System.Drawing.Printing;
using HW6.Helper;

namespace HW6
{
    public class PrintTaskPage
    {
        public static string StringToPrint;
        private static string _printString;

        private static void PrintPageHandler(object sender, PrintPageEventArgs page)
        {
            page.Graphics.DrawString(_printString, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        public static void PrintMenu()
        {
            Console.Write("Do you want print current status garland? (1 - Yes, 2 - No): ");
            switch (GetValue.ReadValueConsoleToMenu(2))
            {
                case 1:
                    _printString = StringToPrint;
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);
                    printDocument.Print();
                    break;
                default:
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
