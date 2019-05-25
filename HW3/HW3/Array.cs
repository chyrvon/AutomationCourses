using System;

namespace HW3
{
    public class UserArray
    {
        private protected int _startArray;
        private protected int _endArray;
        public int startArray
        {
            get
            {
                return _startArray; 
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"{value} is not valid.");
                    _startArray = new Random().Next(Constants.MinValueNumber, 500);
                    Console.WriteLine($"Set random value: {_startArray}");
                }
                else
                {
                    _startArray = value;
                }
            }
        }
        public int endArray
        {
            get
            {
                return _endArray;
            }
            set
            {
                if (value <= 0 || value < _startArray + Constants.MinElementsArray)
                {
                    Console.WriteLine($"Your range is not valid {value - _startArray}. " +
                        $"Min range {Constants.MinElementsArray}.");
                    _endArray = _startArray + Constants.MinElementsArray;
                    Console.WriteLine($"Set value: {_endArray - 1}");
                    Console.ReadLine();
                }
                else
                {
                    _endArray = value;
                }
            }
        }
        public int[] numbers = new int[1];
                
        public UserArray()
        {
            FillArray();
        }

        private int [] FillArray()
        {
            startArray = new GetValue().ReadValueConsole("\nEnter start number of array: ");
            endArray = new GetValue().ReadValueConsole($"\nEnter end number of array: ");
            Console.Clear();
            Console.WriteLine($"Your array range from {startArray} to {endArray}");
            int size = endArray - startArray + 1;
            Array.Resize(ref numbers, size);
            int value = startArray;
            for (int i = 0; i < size; i++)
            {
                numbers[i] = value;
                value++;
            }
            return numbers;
        }

        public void DisplayArray()
        {
            Console.WriteLine("Array:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
