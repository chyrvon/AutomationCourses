using System;
namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterWord =  new GetValue().ReadValueConsole("Enter a word: ");
            new CompareWord(enterWord);
            Console.ReadKey();
        }
    }
}
