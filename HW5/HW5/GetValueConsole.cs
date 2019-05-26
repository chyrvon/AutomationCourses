using System;
using System.Text.RegularExpressions;

namespace HW5
{
    public class GetValue
    {
        public int ReadValueConsole(string strMessage)
        {
            int value = 0;
            Console.Write(strMessage);
            for (int _reTry = 1; _reTry <= Constants.ReTry; _reTry++)
            {
                int.TryParse(Console.ReadLine(), out value);
                if (value <= 0 && _reTry < Constants.ReTry)
                {
                    Console.Write($"The entered value is not valid. "
                        + $"Attempts left: {Constants.ReTry - _reTry}. Try again: ");
                }
                else
                {
                    return value;
                }
            }
            return value;
        }

        public int ReadValueConsole(string strMessage, bool priorityOrDifficult)
        {
            int value = 0;
            string tmpValue;

            if (priorityOrDifficult)
            {
                Console.Write("\n" + strMessage + $", (1 - {Constants.PriorityHigh}, " +
                $"2 - {Constants.PriorityMed}, 3 - {Constants.PriorityLow}): ");
            }
            else
            {
                Console.Write("\n" + strMessage + $", (1 - {Constants.DifficultHard}, " +
                $"2 - {Constants.DifficultMed}, 3 - {Constants.DifficultEasy}): ");
            }

            for (int _reTry = 1; _reTry <= Constants.ReTry; _reTry++)
            {
                tmpValue = Console.ReadLine();
                try
                {
                    int.TryParse(tmpValue, out value);
                    if ((value < 1 || value > 3) && _reTry <= Constants.ReTry)
                    {
                        if (tmpValue.Length > 0) throw new Exception("Chars");
                        Console.Write($"The entered value is not valid. "
                        + $"Attempts left: {Constants.ReTry - _reTry}. Try again: ");
                    }
                    else
                    {
                        return value;
                    }
                }
                catch
                {
                    tmpValue = tmpValue.ToLower();
                    if (tmpValue.Length > 0)
                    {
                        tmpValue = tmpValue.Substring(0, 1).ToUpper()
                            + tmpValue.Substring(1, tmpValue.Length - 1); //first char upper
                    }

                    if (priorityOrDifficult)
                    {
                        switch (tmpValue)
                        {
                            case Constants.PriorityHigh:
                                value = 1;
                                break;
                            case Constants.PriorityMed:
                                value = 2;
                                break;
                            case Constants.PriorityLow:
                                value = 3;
                                break;
                            default:
                                Console.Write($"The entered value is not valid. "
                            + $"Attempts left: {Constants.ReTry - _reTry}. Try again: ");
                                break;
                        }
                    }
                    else
                    {
                        switch (tmpValue)
                        {
                            case Constants.DifficultHard:
                                value = 1;
                                break;
                            case Constants.DifficultMed:
                                value = 2;
                                break;
                            case Constants.DifficultEasy:
                                value = 3;
                                break;
                            default:
                                Console.Write($"The entered value is not valid. "
                            + $"Attempts left: {Constants.ReTry - _reTry}. Try again: ");
                                break;
                        }
                    }
                    if (value > 0) return value;
                }
            }
            return value;
        }
    }
}