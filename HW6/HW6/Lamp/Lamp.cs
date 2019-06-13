using System;
namespace HW6
{
    public class Lamp
    {
        public string StatusLamp { get; private set; }
        private int _indexNumber;
        public int IndexNumber {
            get
            {
                return _indexNumber;
            }
            set
            {
                if (0 > value || value > 1000)
                {
                    Console.WriteLine($"{value} is not valid.");
                    _indexNumber = Garland<Lamp>.DefaultNumberOfLamps; 
                    Console.WriteLine($"Set default value: {_indexNumber}");
                }
                else
                {
                    _indexNumber = value;
                }
            }
        }

        public Lamp(int indexNumber)
        {
            IndexNumber = indexNumber;
        }

        public string GetStatusLamp(bool currentEvenMinute)
        {
            if (IndexNumber % 2 == 0 ^ currentEvenMinute)
            {
                StatusLamp = "On";
            }
            else
            {
                StatusLamp = "Off";
            }
            return StatusLamp;
        }
    }
}
