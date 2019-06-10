using System;
using System.Collections.Generic;
using HW7.Helper;

namespace HW7
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            DictionaryCountries dictionaryCountries = new DictionaryCountries();

            GetDataFromFile.GetCountriesFromFile(dictionaryCountries);
            Console.Write("\nEnter Country for add to Dictionary: ");
            dictionaryCountries.AddCountry(Console.ReadLine());
            Console.WriteLine("\nNew Dictionary:\n");
            PrintHelper.DisplayCountries(dictionaryCountries);

            dictionaryCountries.SetTelenorSupported("Denmark");
            dictionaryCountries.SetTelenorSupported("Hungary");

            int i = 1;
            PrintHelper.StringToPrint += "\nIsTelenorSupported = False for: \n";
            foreach (KeyValuePair<int, Country> keyValue in dictionaryCountries.countries)
            {
                if (keyValue.Value.IsTelenorSupported == false)
                {
                    PrintHelper.StringToPrint += $"{i++}. {keyValue.Value.Name}\n";
                }
            }
            Console.WriteLine(PrintHelper.StringToPrint);
            new PrintHelper();
            Console.ReadKey();
        }
    }
}
