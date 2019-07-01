using System;
using System.Collections.Generic;
using System.Text;

namespace HW8
{
    class RandomNumberGenerator
    {
        public string GetRndString()
        {
            return $"{new Random().Next(10000)}";
        }

        public int GetRndInt()
        {
            return new Random().Next(10000);
        }
    }
}
