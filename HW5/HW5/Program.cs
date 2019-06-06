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
            Console.ReadLine();

            //1 - how much time is needed to complete all tasks
            taskManager.AllTime(tasksList);

            //2 - list of tasks of a given priority
            Console.WriteLine("Enter priority for build list");
            Console.Write($"(1 - {Priority.High}, " +
                 $"2 - {Priority.Medium}, 3 - {Priority.Low}): ");
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