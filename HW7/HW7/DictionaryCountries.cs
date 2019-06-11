using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW7
{
    public class DictionaryCountries
    {
        public Dictionary<int, Country> countries = new Dictionary<int, Country>();
        private string _addNameCountry;

        string AddNameCountry
        {
            get
            {
                return _addNameCountry;
            }
            set
            {
                Regex dictionaryChars = new Regex("^[a-zA-Zа-яА-Я]*$");
                if (!dictionaryChars.IsMatch(value))
                {
                    _addNameCountry = "Ukraine";
                    Console.WriteLine($"Wrong value. Set defaultValue - {_addNameCountry}");
                    Console.ReadKey();
                }
                _addNameCountry = value;
            }
        }

        public void AddCountry(string addNameCountry, bool isTelenorSupported = false)
        {
            AddNameCountry = addNameCountry;
            int count = countries.Count + 1;
            countries.Add(count, new Country(AddNameCountry, isTelenorSupported));
        }

        public void SetTelenorSupported(string Country)
        {
            countries.Where(x => x.Value.Name.Equals(Country)).ToDictionary(x => x.Value.IsTelenorSupported = true);
        }
    }
}
