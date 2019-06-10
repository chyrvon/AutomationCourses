using System;
using System.Collections.Generic;
using System.Linq;
using HW5.Enums;
namespace HW5
{
    public class FilterTaskByPriority
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
                    var random = new Random();
                    Console.WriteLine($"{value} is not valid.");
                    _priority = random.Next(1, Enum.GetNames(typeof(Priority)).Length);
                    Console.WriteLine($"Set random value: {_priority}");
                }
                else
                {
                    _priority = value;
                }
            }
        }
        public FilterTaskByPriority(Enum getPriority, List<Task> tasksArrayList)
        { 
            PreparationPrinting($"List of Task with priority {getPriority}");

            List<Task> responseTasksFromListByPriority = new List<Task>();
            responseTasksFromListByPriority.AddRange(tasksArrayList.Where(x => x.Priority.Equals(getPriority)).ToList());

            for (int i = 0; i < responseTasksFromListByPriority.Count; i++)
            {
                PreparationPrinting($"\nTask {responseTasksFromListByPriority[i].Number}");
            }
        }
        private void PreparationPrinting(string strMessage)
        {
            Console.WriteLine(strMessage);
            PrintTaskPage.StringToPrint += $"\n" + strMessage;
        }
    }
}
