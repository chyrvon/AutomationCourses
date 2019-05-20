using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class UserArray
    {
        public static int startArray = 0;
        public static int endArray = 0;
        public static int EnterValue(string strMessage, int countNumbArray = 1)
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

        public static int[] FillArray(int [] numbers)
        {
            int tmp = 0;
            
            for (int i = 0; i < Constants.MaxReTry; i++)
            {
                startArray = EnterValue($"\nEnter start number of array: ");
                endArray = EnterValue($"\nEnter end number of array: ");
                tmp = endArray - startArray;
                if (tmp < Constants.MinValueArray)
                {
                    Console.WriteLine($"Your range is not valid {tmp}. Min range {Constants.MinValueArray}. Try again.");
                }
                else break;
            }
            Console.Clear();
            Console.WriteLine($"Your range from {startArray} to {endArray}");
            int tmp2 = startArray;
            for (int i = 0; i <= tmp; i++)
            {
                numbers[i] = tmp2;
                tmp2++;
            }
            return numbers;
        }

        public static int LenghtArray(int [] numbers)
        {
            int lenghtArray = 0;
            for (int i = 1; i <= Constants.MaxValueArray; i++)
            {
                if (numbers[i] > 0) lenghtArray++;
                else break;
            }
            return lenghtArray;
        }

        public static void DisplayArray(int [] numbers)
        {
            Console.WriteLine("Array:");
            for (int i = 0; i <= LenghtArray(numbers)-1; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
