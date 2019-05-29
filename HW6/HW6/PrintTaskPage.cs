using System;
using System.Drawing;
using System.Drawing.Printing;

namespace HW6
{
    public class PrintTaskPage
    {
        public static string StringToPrn;
        private string _printString;

        public void StartPrint()
        {
            _printString = StringToPrn;
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);
            printDocument.Print();
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs page)
        {
            page.Graphics.DrawString(_printString, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        public void PrintMenu()
        {
            Console.Write("Do you want print current status garland? (1 - Yes, 2 - No): ");
            switch (new GetValue().ReadValueConsoleToMenu())
            {
                case 1:
                    StartPrint();
                    break;
                default:
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
