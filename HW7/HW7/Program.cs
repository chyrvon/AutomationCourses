using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace HW7
{
    public static class Globals
    {
        public static Dictionary<int, Country> countries = new Dictionary<int, Country>();
        public static int countCountry;
    }







    class DictionaryCountries
    {
        public static string ToPrint = "";
       
        public static void AddCountry(string AddNameCountry)
        {
            Globals.countCountry++;
            Globals.countries.Add(Globals.countCountry, new Country(AddNameCountry));
        }


        public static void SetTelenorSupported(string Country)
        {
            foreach (KeyValuePair<int, Country> keyValue in Globals.countries)
            {
                if (keyValue.Value.Name == Country)
                    keyValue.Value.IsTelenorSupported = true;
            }
        }










        public static void PrintPDF()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);
            printDocument.Print();
        }
        private static void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ToPrint, new Font("Arial", 14), Brushes.Black, 0, 0);

        }
    }

    
}

namespace HW7
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            GetDataFromFile.GetCountriesFromFile();
            Console.WriteLine("Enter Country for add to Dictionary: ");
            DictionaryCountries.AddCountry(Console.ReadLine());
            Console.Clear();
            int i = 1;
            Console.WriteLine("New Dictionary:\n");
            foreach (KeyValuePair<int, Country> keyValue in Globals.countries)
            {
                Console.WriteLine($"{i}. {keyValue.Value.Name}");
                i++;
            }
            DictionaryCountries.SetTelenorSupported("Denmark");
            DictionaryCountries.SetTelenorSupported("Hungary");




            i = 1;
            DictionaryCountries.ToPrint += "\nIsTelenorSupported = False for: \n";
            foreach (KeyValuePair<int, Country> keyValue in Globals.countries)
            {
                if (keyValue.Value.IsTelenorSupported == false)
                {
                    DictionaryCountries.ToPrint += $"{i}. {keyValue.Value.Name}\n";
                    i++;
                }
            }
            Console.WriteLine(DictionaryCountries.ToPrint);
            DictionaryCountries.PrintPDF();
            Console.ReadKey();
        }
    }
}
