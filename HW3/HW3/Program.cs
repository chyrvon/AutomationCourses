using System;

namespace CustomMethods
{
    static class Constants
    {
        public const int MaxValueArray = 100;
        public const int MinValueArray = 10;
        public const int DivNum = 3;
        public const int NDivNum = 5;
    }

    public static class Сalculation
    {
        public static int EnterValue(string StrMessage, int i)
        {
            int Value;
            Console.Write(StrMessage);
        RetryEnterLengthSide:
            try
            {
                Value = Convert.ToInt32(Console.ReadLine());
                if ((Value == 0) & (i > Constants.MinValueArray)) return Value;
                if (Value < 20) throw new NullReferenceException();
            }
            catch
            {
                Console.Write("Введено не валидное значение, введите натуральное число больше 20: ");
                goto RetryEnterLengthSide;
            }
            return Value;
        }
        public static int Sum(int[] numbers)
        {
            int LenghtArray = 0;
            int Summa = 0;
            for (int i = 1; i <= Constants.MaxValueArray; i++)
            {
                if (numbers[i] > 0) LenghtArray++;
                else break;
            }
            for (int i = 1; i <= LenghtArray; i++)
            {
                if ((numbers[i] % Constants.DivNum == 0) & (numbers[i] % Constants.NDivNum != 0))
                {
                    Summa = Summa + numbers[i];
                }
            }
            return Summa;
        }
    }
}

namespace HW_Task2
{
    using CustomMethods;
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[Constants.MaxValueArray];
            Console.WriteLine($"Введите диапазон (не меньше {Constants.MinValueArray}) натуаральных чисел, начиная с 20. Для завершение ввода диапазона чисел введите 0");
            for (int i = 1; i <= Constants.MaxValueArray; i++)
            {
                numbers [i] = Сalculation.EnterValue($"\n {i} натуральное число: ", i);
                if (numbers[i] == 0) break;
            }
            Console.WriteLine($"\nСумма чисел которые делятся на {Constants.DivNum} и не делятся на {Constants.NDivNum} равна: {Сalculation.Sum(numbers)}");
            Console.ReadKey();
        }
    }
}


