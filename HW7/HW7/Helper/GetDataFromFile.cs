using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HW7.Helper
{ 
    public class GetDataFromFile
    {
        public static void GetCountriesFromFile(DictionaryCountries dictionaryCountries)
        {
            try
            {
                Console.WriteLine("Reading Countries:\n");
                int i = 0;
                using (StreamReader sr = new StreamReader(Const.Path, System.Text.Encoding.Default))
                {
                    string LineFromFile;
                    while ((LineFromFile = sr.ReadLine()) != null)
                    {
                        if (i == 0)
                        {
                            i++;
                            continue;
                        }
                        List<string> tmp = LineFromFile.Split('\t').ToList();
                        Console.WriteLine($"{i, 3}. {tmp.First(), -20}     {tmp.Last(), -20}");
                        dictionaryCountries.countries.Add(i, new Country(tmp.First(), bool.Parse(tmp.Last())));
                        i++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
