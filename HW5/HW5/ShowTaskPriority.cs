using System;

namespace HW5
{
    public class ShowTaskPriority
    {
        private protected int _priority;
        private int priority
        {
            get
            {
                return _priority;
            }
            set
            {
                if (value < 1 || value > 3)
                {
                    Console.WriteLine($"{value} is not valid.");
                    _priority = new Random().Next(1, 3);
                    Console.WriteLine($"Set random value: {_priority}");
                }
                else
                {
                    _priority = value;
                }
            }
        }
        public ShowTaskPriority(int getPriority, int[,] arrayTask)
        {
            priority = getPriority;
            switch (priority)
            {
                case 1:
                    PreparationPrinting ($"List of Task with priority {Constants.PriorityHigh}");
                    break;
                case 2:
                    PreparationPrinting($"List of Task with priority {Constants.PriorityMed}");
                    break;
                case 3:
                    PreparationPrinting($"List of Task with priority {Constants.PriorityLow}");
                    break;
            }
            for (int i = 0; i < arrayTask.GetLength(0); i++)
            {
                if (arrayTask[i, 1] == priority)
                {
                    PreparationPrinting($"\nTask {arrayTask[i, 0]}");
                }
            }
        }
        private void PreparationPrinting(string strMessage)
        {
            Console.Write($"\n" + strMessage);
            PrintTaskPage.StringToPrn += $"\n" + strMessage;
        }
    }
}
