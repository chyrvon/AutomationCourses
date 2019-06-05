using System;
using System.Collections.Generic;
using System.Linq;
using HW5.Enums;
using HW5.Helper;
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
                    _nDayDoneTasks = 1;
                    Console.WriteLine($"Set default value: {_nDayDoneTasks}");
                }
                else
                {
                    _nDayDoneTasks = value;
                }
            }
        }

        public void AllTime(List<Task> tasksArrayList)
        {
            int value = 0;
            tasksArrayList.ForEach(x => value += x.Duration);
            Console.WriteLine($"\nTime needed for complete all Tasks, h: {value}");
            PrintTaskPage.StringToPrint += $"\nTime needed for complete all Tasks, h: {value}";
        }

        public int TimeAfterTask(int intPriority, int timeLeft, List<Task> tasksArrayList)
        {
            string priority = "";
            switch (intPriority)
            {
                case 1:
                    priority = PriorityEnum.High.ToString();
                    break;
                case 2:
                    priority = PriorityEnum.Medium.ToString();
                    break;
                case 3:
                    priority = PriorityEnum.Low.ToString();
                    break;
            }

            if (timeLeft > 0)
            {
                int tmpTime;
                for (int i = 0; i < tasksArrayList.Count; i++)
                {
                    if (tasksArrayList[i].Priority == priority)
                    {
                        tmpTime = timeLeft;
                        tmpTime -= tasksArrayList[i].Duration;
                        if (tmpTime >= 0)
                        {
                            timeLeft = tmpTime;
                            Console.Write($"\n Task {tasksArrayList[i].Number}");
                            PrintTaskPage.StringToPrint += $"\n Task { tasksArrayList[i].Number}";
                        }
                    }
                }
            }
            return timeLeft;
        }

        public void TaskCanBeDone(List<Task> tasksArrayList)
        {
            nDayDoneTasks = new GetValue().ReadValueConsole("\nEnter value of days for completed all tasks: ");

            Console.Write($"\nIt is possible to perform the following tasks in {nDayDoneTasks} days: ");
            PrintTaskPage.StringToPrint += $"\nIt is possible to perform the following tasks in {nDayDoneTasks} days: ";

            int timeLeft = nDayDoneTasks * Constants.WorkHours;
            for (int i = 1; i < 4; i++)
            {
                if (timeLeft > 0)
                {
                    timeLeft = TimeAfterTask(i, timeLeft, tasksArrayList);
                    if (i == 3) Console.Write($"\nLeft time: {timeLeft} h");
                }
                else break;
            }
        }

        public List<Task> SortListTasks(List<Task> tasksList)
        {
            List<Task> sortTasksList = new List<Task>();
            for (int t = 1; t <= 3; t++)
            {
                for (int y = 1; y <= 3; y++)
                {
                    PriorityEnum priorityEnumCompare = (PriorityEnum)Enum.GetValues(typeof(PriorityEnum)).GetValue(t-1);
                    DifficultyListEnum difficultyEnumCompare = (DifficultyListEnum)Enum.GetValues(typeof(DifficultyListEnum)).GetValue(y-1);
                    sortTasksList.AddRange(tasksList.Where(x => (x.Priority == priorityEnumCompare.ToString()) &
                        (x.Difficulty == difficultyEnumCompare.ToString())).ToList());
                }
            }
            return sortTasksList;
        }
    }
}
