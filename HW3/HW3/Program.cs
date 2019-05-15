using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[Constants.MaxValueArray];
            Console.WriteLine($"Enter a range(at least {Constants.MinValueArray}) of integer numbers starting from {Constants.MinValueNumber}.\nTo complete the input enter 1");
            numbers = new Array().FillArray(numbers);
            new Array().DisplayArray(numbers);
            Console.WriteLine($"\nThe sum of the numbers are divided by {Constants.NumberDiv} and not divisible by {Constants.NumberNotDiv} equals: {Сalculation.Sum(numbers)}");
            Console.ReadKey();
        }
    }
}


