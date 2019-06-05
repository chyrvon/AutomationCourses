using System;
using System.Collections.Generic;
using HW5.Enums;
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
        public ShowTaskPriority(string getPriority, List<Task> tasksArrayList)
        { 
            PriorityEnum listPriority;
            Enum.TryParse(getPriority, true, out listPriority);
            PreparationPrinting($"List of Task with priority {listPriority}");

            for (int i = 0; i < tasksArrayList.Count; i++)
            {
                if (tasksArrayList[i].Priority == listPriority.ToString())
                {
                    PreparationPrinting($"\nTask {tasksArrayList[i].Number}");
                }
            }
        }
        private void PreparationPrinting(string strMessage)
        {
            Console.WriteLine(strMessage);
            PrintTaskPage.StringToPrint += $"\n" + strMessage;
        }
    }
}
