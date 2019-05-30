using System;

namespace HW4
{
    public class CompareWord
    {
        public CompareWord(string enterWord)
        { 
            string convWord = string.Empty;
            enterWord = enterWord.ToLower();

            for (int i = 0; i < enterWord.Length; i++)
            {
                convWord += enterWord[enterWord.Length - i - 1];
            }
            if (enterWord.Equals(convWord) == true)
            {
                Console.Write($"Yes, '{enterWord}' is a palindrome");
            }
            else
            {
                Console.Write($"No, '{enterWord}' isn't a palindrome");
            }
        }
    }
}
