using System;
using System.Collections.Generic;

namespace HW7
{
    class Country
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
