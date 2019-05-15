using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Array
    {
        public Array()
        {
        }

        public int EnterValue(string strMessage, int countNumbArray)
        {
            int value = 0;
            Console.Write(strMessage);
            for (int retry = 1; retry < Constants.MaxReTry + 1; retry++)
            {
                int.TryParse(Console.ReadLine(), out value);

                if ((value == 1) && (countNumbArray > Constants.MinValueArray))//input complete
                {
                    return value;
                }
                if (value < Constants.MinValueNumber)
                {
                    if (retry != Constants.MaxReTry)
                    {
                        Console.Write($"The entered value is not valid. Attempts left: {Constants.MaxReTry - retry}. Try again.\nEnter an integer number in the range 20-32767: ");
                    }
                }
                else
                {
                    return value;
                }
            }
            Random random = new Random();
            value = random.Next(Constants.MinValueNumber, 40);
            Console.Write($"\nAutocomplete number to array: {value}\n");
            return value;
        }

        public int[] FillArray(int [] numbers)
        {
            int tmp = 0;
            for (int i = 1; i <= Constants.MaxValueArray; i++)
            {
                tmp = new Array().EnterValue($"\nEnter {i} integer number: ", i);
                if (tmp != 1)
                {
                    numbers[i] = tmp;
                }
                else break;
            }
            return numbers;
        }

        public int LenghtArray(int [] numbers)
        {
            int lenghtArray = 0;
            for (int i = 1; i <= Constants.MaxValueArray; i++)
            {
                if (numbers[i] > 0) lenghtArray++;
                else break;
            }
            return lenghtArray;
        }

        public void DisplayArray(int [] numbers)
        {
            Console.Clear();
            Console.WriteLine("Array:");
            for (int i = 1; i <= LenghtArray(numbers); i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
