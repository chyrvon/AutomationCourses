using System;
namespace HW3
{
    class Сalculation
    {
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            int lenghtArray = UserArray.LenghtArray(numbers);
            for (int i = 1; i <= lenghtArray; i++)
            {
                if ((numbers[i] % Constants.NumberDiv == 0) && (numbers[i] % Constants.NumberNotDiv != 0))
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public static void SumAndDisplay(int startArray, int endArray)
        {
            int sum = 0;

            for (int i = startArray+1; i <= endArray; i++)
            {
                if ((i % Constants.NumberDiv == 0) && (i % Constants.NumberNotDiv != 0))
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"\nThe sum of the numbers are divided by {Constants.NumberDiv} " +
                $"and not divisible by {Constants.NumberNotDiv} equals: {sum}");
        }
    }
}
