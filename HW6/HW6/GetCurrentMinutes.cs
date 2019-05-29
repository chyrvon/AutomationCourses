using System;

namespace HW6
{
    public class GetCurrentMinutes
    {
        //get current time
        public bool CurrentMinutes()
        {
            string currentMinutes = DateTime.Now.ToShortTimeString();
            Console.WriteLine($"Current time: {currentMinutes}");
            Int32.TryParse(currentMinutes.Substring(currentMinutes.Length - 1), out int lastNumberMinute);
            return lastNumberMinute % 2 == 0;
        }
    }
}
