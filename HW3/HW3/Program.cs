using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter a range(at least {Constants.MinElementsArray}) of integer " +
            $"numbers starting from {Constants.MinValueNumber}.");

            UserArray numb = new UserArray();
            numb.DisplayArray();

            Console.WriteLine($"\nThe sum of the numbers are divided by {Constants.NumberDiv} " +
                $"and not divisible by {Constants.NumberNotDiv} equals: {new Сalculation().Sum(numb.numbers)}");
            Console.ReadKey();
            Console.Clear();
            new Сalculation().SumAndDisplay(numb.startArray, numb.endArray);
        }
    }
}


