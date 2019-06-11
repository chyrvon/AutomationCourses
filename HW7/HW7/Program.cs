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

            PrintHelper.DisplayCountries(dictionaryCountries);
            //Console.WriteLine(PrintHelper.StringToPrint);
            // new PrintHelper();
            SaveDataToFile.SetCountriesToFile(dictionaryCountries);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }

}
