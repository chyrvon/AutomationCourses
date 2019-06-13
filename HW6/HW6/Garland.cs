using System;
namespace HW6
{
    public abstract class Garland<T> where T : Lamp
    {
        public const int DefaultNumberOfLamps = 10;
        public T[] _garland;

        public Garland(int garlandLength)
        {
            _garland = new T[garlandLength];
        }

        public virtual void ShowStatusGarland()
        {
            bool сurrentMinuteEvenOrOdd = GetCurrentMinutes.EvenOrOdd();
            Console.WriteLine("Simple garland status:");
            foreach (Lamp i in _garland)
            {
                new ConsoleChangeColor(i.GetStatusLamp(сurrentMinuteEvenOrOdd), "Yellow");
                string stringToShow = $"{i.IndexNumber + 1} lamp is {i.GetStatusLamp(сurrentMinuteEvenOrOdd)}";
                Console.WriteLine(stringToShow);
                Console.ResetColor();
                PrintTaskPage.StringToPrint += stringToShow;
            }
        }
    }
}
