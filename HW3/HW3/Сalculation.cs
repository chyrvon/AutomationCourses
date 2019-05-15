using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Сalculation
    {
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            int lenghtArray = new Array().LenghtArray(numbers);
            for (int i = 1; i <= lenghtArray; i++)
            {
                if ((numbers[i] % Constants.NumberDiv == 0) & (numbers[i] % Constants.NumberNotDiv != 0))
                {
                    sum = sum + numbers[i];
                }
            }
            return sum;
        }
    }
}
