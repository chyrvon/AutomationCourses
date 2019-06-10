using System;
using System.Collections.Generic;

namespace HW7
{
    public class DictionaryCountries
    {
        public int countCountry { get; set; }
        public Dictionary<int, Country> countries = new Dictionary<int, Country>();

        public void AddCountry(string AddNameCountry)
        {
            countCountry++;
            countries.Add(countCountry, new Country(AddNameCountry));
        }

        public void SetTelenorSupported(string Country)
        {
            foreach (KeyValuePair<int, Country> keyValue in countries)
            {
                if (keyValue.Value.Name.Equals(Country))
                {
                    keyValue.Value.IsTelenorSupported = true;
                }
            }
        }
    }
}
