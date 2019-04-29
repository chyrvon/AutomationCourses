using System;
namespace HW_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Word = "";
            string ConWord = "";
            Console.WriteLine("Введите слово:");
            Word = Console.ReadLine();
            Word = Word.ToLower();
            for (int i = 0; i < Word.Length; i++)
            {
                ConWord += Word[Word.Length - i - 1];
            }
            if (Word.Equals(ConWord) == true) Console.Write($"Да, слово {Word} является палиндромом");
            else Console.Write($"Нет, слово {Word} не является палиндромом");
            Console.ReadKey();
        }
    }
}
