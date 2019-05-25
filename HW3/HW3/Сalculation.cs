using System;
namespace HW3
{
    class Сalculation
    {
        public int Sum(int[] numbers)
        {
            int sum = 0;
            int lenghtArray = numbers.Length;
            for (int i = 0; i <= lenghtArray-1; i++)
            {
                if ((numbers[i] % Constants.NumberDiv == 0) && (numbers[i] % Constants.NumberNotDiv != 0))
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public void SumAndDisplay(int startArray, int endArray)
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
            Console.ReadKey();
        }
    }
}
