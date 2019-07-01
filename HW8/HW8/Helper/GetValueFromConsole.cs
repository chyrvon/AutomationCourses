using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using HW8;

namespace HW8.Helper
{
    public class GetValue
    {
        public static string ReadValueFromConsole(string strMessage, bool isPhone = false, bool isStatusDelivery = false)
        {
            string enterValue = null;
            Regex dictionaryChars;
            Console.Write(strMessage);
            for (int _reTry = 1; _reTry <= Constants.ReTryAttempsCount; _reTry++)
            {
                enterValue = Console.ReadLine();
                enterValue = enterValue.Replace(" ", "");
                enterValue = enterValue.ToLower();
                enterValue = enterValue.Substring(0, 1).ToUpper() + (enterValue.Length > 1 ? enterValue.Substring(1) : "");
                
                if (enterValue.Length > 3 && enterValue.Length < 20)
                {
                    if (isPhone)
                    {
                        dictionaryChars = new Regex("^[0-9a-fA-F]*$");
                    }
                    else
                    {
                        dictionaryChars = new Regex("^[a-zA-Zа-яА-Я]*$");
                    }

                    if (!dictionaryChars.IsMatch(enterValue))
                    {
                        Console.Write($"The entered value is not valid. "
                            + $"Attempts left: {Constants.ReTryAttempsCount - _reTry}. Try again: ");
                    }
                    else
                    {
                        return enterValue;
                    }
                }
                else
                {
                    Console.WriteLine("Enter value is short (<3) or longer (>20). Try again!");
                }
                if (_reTry >= Constants.ReTryAttempsCount)
                {
                    Console.Clear();
                    enterValue = "";
                }
            }
            return enterValue;
        }
        public static int ReadIntValueFromConsole(string strMessage, bool isValidationMaxValue = false, int maxValue = 4)
        {
            int enterValue = 0;
            Console.Write(strMessage);
            for (int _reTry = 1; _reTry <= Constants.ReTryAttempsCount; _reTry++)
            {
                int.TryParse(Console.ReadLine(), out enterValue);

                if (isValidationMaxValue)
                {
                    if ((enterValue < 1 || enterValue > maxValue) && _reTry != Constants.ReTryAttempsCount)
                    {
                        Console.Write($"The entered value is not valid. "
                            + $"Attempts left: {Constants.ReTryAttempsCount - _reTry}. Try again: ");
                    }
                    else
                    {
                        return enterValue;
                    }
                }
                else
                {
                    if (enterValue <= 0 && _reTry < Constants.ReTryAttempsCount)
                    {
                        Console.Write($"The entered value is not valid. "
                            + $"Attempts left: {Constants.ReTryAttempsCount - _reTry}. Try again: ");
                    }
                    else
                    {
                        return enterValue;
                    }
                }
            }
            return enterValue = 0;
        }
    }
}
