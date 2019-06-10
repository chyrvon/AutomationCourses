using HW5.Enums;
using System;

namespace HW5.Helper
{
    public class GetValue
    {
        public int ReadValueFromConsole(string strMessage)
        {
            int value = 0;
            Console.Write(strMessage);
            for (int _reTry = 1; _reTry <= Constants.ReTryAttempsCount; _reTry++)
            {
                int.TryParse(Console.ReadLine(), out value);
                if (value <= 0 && _reTry < Constants.ReTryAttempsCount)
                {
                    Console.Write($"The entered value is not valid. "
                        + $"Attempts left: {Constants.ReTryAttempsCount - _reTry}. Try again: ");
                }
                else
                {
                    return value;
                }
            }
            return value;
        }
      
        public static TEnum ValidationValue<TEnum>() where TEnum : struct, Enum
        {
            TEnum value;
            for (int _reTry = 1; _reTry <= Constants.ReTryAttempsCount; _reTry++)
            {
                if (Enum.TryParse(Console.ReadLine(), true, out value) && Enum.IsDefined(typeof(TEnum), value))
                {
                    return value;
                }
                else
                {
                    if (_reTry != Constants.ReTryAttempsCount)
                    {
                        Console.Write($"The entered value is not valid. "
                        + $"Attempts left: {Constants.ReTryAttempsCount - _reTry}. Try again: ");
                    }
                    else
                    {
                        Enum.TryParse(3.ToString(), out value);
                        Console.WriteLine($"Set default value: {value}");
                    }
                }
            }
            Enum.TryParse(3.ToString(), out value);
            return value;
        }
    }
}