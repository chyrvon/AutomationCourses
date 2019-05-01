using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace Custom
{
    public static class Globals
    {
        public static Dictionary<int, Country> countries = new Dictionary<int, Country>();
        public static int countCountry;
    }

    class DictionaryCountries
    {
        public static string ToPrn = "";

        public static void GetCountriesFromFile()
        {
            string Path = @"D:\AutomationCourses\HW6\EC.txt"; //default
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Document";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";
            if (dlg.ShowDialog() != DialogResult.Cancel) Path = dlg.FileName;
            try
            {
                Console.WriteLine("Reading Countries:\n");
                int i = 1;
                using (StreamReader sr = new StreamReader(Path, System.Text.Encoding.Default))
                {
                    string LineFromFile;
                    while ((LineFromFile = sr.ReadLine()) != null)
                    {
                        Console.WriteLine($"{i}. {LineFromFile}");
                        Globals.countries.Add(i, new Country(LineFromFile));
                        i++;
                    }
                }
                Globals.countCountry = i;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

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
            e.Graphics.DrawString(ToPrn, new Font("Arial", 14), Brushes.Black, 0, 0);

        }
    }

    public class Country
    {
        public string Name;
        public bool IsTelenorSupported;

        public Country()
        {
            Name = "";
            IsTelenorSupported = false;
        }

        public Country(string Name)
        {
            this.Name = Name;
        }
    }
}

namespace HW6
{
    using Custom;
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            DictionaryCountries.GetCountriesFromFile();
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
            DictionaryCountries.ToPrn += "\nIsTelenorSupported = False for: \n";
            foreach (KeyValuePair<int, Country> keyValue in Globals.countries)
            {
                if (keyValue.Value.IsTelenorSupported == false)
                {
                    DictionaryCountries.ToPrn += $"{i}. {keyValue.Value.Name}\n";
                    i++;
                }
            }
            Console.WriteLine(DictionaryCountries.ToPrn);
            DictionaryCountries.PrintPDF();
            Console.ReadKey();
        }
    }
}
