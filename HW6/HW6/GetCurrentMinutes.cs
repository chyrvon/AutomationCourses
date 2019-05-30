using System;

namespace HW6
{
    public class GetCurrentMinutes
    {
        public bool CurrentMinutes()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine($"Current time: {date.ToShortTimeString()}");
            return date.Minute % 2 == 0;
        }
    }
}
