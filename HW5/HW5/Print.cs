using System.Drawing;
using System.Drawing.Printing;

namespace HW5
{
    public class PrintTaskPage
    {
        public static string StringToPrn;
        private string PrintString;
        public PrintTaskPage()
        {
            PrintString = StringToPrn;
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);
            printDocument.Print();
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs page)
        {
            page.Graphics.DrawString(PrintString, new Font("Arial", 14), Brushes.Black, 0, 0);

        }
    }
}
