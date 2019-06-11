using System;
using System.Collections.Generic;
using System.Linq;
using HW5.Enums;
using HW5.Helper;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            List<Task> tasksList = new List<Task>();

            tasksList = taskManager.AddNewTasks(tasksList);

            Display(tasksList);
            tasksList = taskManager.SortListTasks(tasksList);
            Console.WriteLine("Sort List by Priority & Difficulty:");
            Display(tasksList);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //1 - how much time is needed to complete all tasks
            taskManager.AllTime(tasksList);

            //2 - list of tasks of a given priority
            taskManager.DisplayConsoleMessage<Priority>($"Enter {typeof(Priority).Name.ToLower()} for build list (");

            Task validation = new Task();
            validation.Priority = GetValue.ValidationValue<Priority>();

            new FilterTaskByPriority(validation.Priority, tasksList);

            //3 - what tasks can be done in N days based on priority
            taskManager.TasksCanBeDone(tasksList);

            //4 - print
            new PrintTaskPage();
            Console.ReadKey();
        }




        public static void Display(List<Task> tasksArrayList)
        {
            //Console.Clear();
            Console.WriteLine("Tasks\t Priority\t Difficult\t Time");
            tasksArrayList.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}