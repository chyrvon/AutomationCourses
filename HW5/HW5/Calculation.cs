using System;

namespace HW5
{
    public class Calculation
    {
        private protected int _nDayDoneTasks;
        private int nDayDoneTasks
        {
            get
            {
                return _nDayDoneTasks;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"{value} is not valid.");
                    _nDayDoneTasks = Constants.DefaultNumerTasks;
                    Console.WriteLine($"Set default value: {_nDayDoneTasks}");
                }
                else
                {
                    _nDayDoneTasks = value;
                }
            }
        }

        public void AllTime(int[,] arrayTask)
        {
            int value = 0;
            for (int i = 0; i < arrayTask.GetLength(0); i++)
            {
                    value += arrayTask[i, 3];
            }
            Console.Write($"\nTime needed for complete all Tasks, h: {value}");
            PrintTaskPage.StringToPrn += $"\nTime needed for complete all Tasks, h: {value}";
        }

        public int TimeAfterTask(int priority, int timeLeft, int[,] arrayTask)
        {
            if (timeLeft > 0)
            {
                int tmpTime;
                for (int i = 0; i < arrayTask.GetLength(0); i++)
                {
                    if (arrayTask[i, 1] == priority)
                    {
                        tmpTime = timeLeft;
                        tmpTime -= arrayTask[i, 3];
                        if (tmpTime >= 0)
                        {
                            timeLeft = tmpTime;
                            Console.Write($"\n Task {arrayTask[i, 0]}");
                            PrintTaskPage.StringToPrn += $"\n Task { arrayTask[i, 0]}";
                        }
                    }
                }
            }
            return timeLeft;
        }

        public void TaskCanBeDone(int[,] arrayTask)
        {
            nDayDoneTasks = new GetValue().ReadValueConsole("\nEnter value of days for completed all tasks: ");
                
            Console.Write($"\nIt is possible to perform the following tasks in {nDayDoneTasks} days: ");
            PrintTaskPage.StringToPrn += $"\nIt is possible to perform the following tasks in {nDayDoneTasks} days: ";

            int timeLeft = nDayDoneTasks * 24;
            for (int i = 1; i < 4; i++)
            {
                if (timeLeft > 0)
                {
                    timeLeft = TimeAfterTask(i, timeLeft, arrayTask);
                    if (i == 3) Console.Write($"\nLeft time: {timeLeft} h");
                }
                else break;
            }
        }
    }
}
