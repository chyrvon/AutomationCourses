using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[Constants.MaxValueArray];
            Console.WriteLine($"Enter a range(at least {Constants.MinValueArray}) of integer " +
            $"numbers starting from {Constants.MinValueNumber}.");
            numbers = UserArray.FillArray(numbers);
            UserArray.DisplayArray(numbers);
            Console.WriteLine($"\nThe sum of the numbers are divided by {Constants.NumberDiv} " +
                $"and not divisible by {Constants.NumberNotDiv} equals: {Сalculation.Sum(numbers)}");
            Console.WriteLine("Ready to Display 2?");
            Console.ReadKey();
            Console.Clear();
            Сalculation.SumAndDisplay(UserArray.startArray, UserArray.endArray);
            Console.ReadKey();
        }
    }
}


