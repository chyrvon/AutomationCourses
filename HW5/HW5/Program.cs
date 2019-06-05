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
            List<Task> tasksList = new List<Task>();
            tasksList = new AddNewTask().AddNewTasks(tasksList);
            new Task().Display(tasksList);
            tasksList = new Calculation().SortListTasks(tasksList);
            Console.WriteLine("Sort List by Priority & difficulty:");
            new Task().Display(tasksList);
            Console.ReadLine();

            //1 - how much time is needed to complete all tasks
            Calculation calculation = new Calculation();
            calculation.AllTime(tasksList);

            //2 - list of tasks of a given priority
            Console.WriteLine("Enter priority for build list");
            Console.Write($"(1 - {PriorityEnum.High}, " +
                 $"2 - {PriorityEnum.Medium}, 3 - {PriorityEnum.Low}): ");
            Task validation = new Task();
            validation.Priority = Console.ReadLine();

            new ShowTaskPriority(validation.Priority, tasksList);

            //3 - what tasks can be done in N days based on priority
            calculation.TaskCanBeDone(tasksList);

            //4 - print
            //new PrintTaskPage();
            Console.ReadKey();
        }
               
        public class AddNewTask
        {
            public List<Task> AddNewTasks(List<Task> tasksArrayList)
            {
                for (int i = 1; i < 1000; i++)
                {
                    Console.Write($"Enter priority for Task {i} (1 - {PriorityEnum.High}, " +
                   $"2 - {PriorityEnum.Medium}, 3 - {PriorityEnum.Low}): ");
                    Task validation = new Task();
                    validation.Priority = Console.ReadLine();

                    Console.Write($"Enter difficulty for Task {i} (1 - {DifficultyListEnum.Hard}, " +
                    $"2 - {DifficultyListEnum.Medium}, 3 - {DifficultyListEnum.Easy}): ");
                    validation.Difficulty = Console.ReadLine();

                    tasksArrayList.Add(new Task(i, validation.Priority, validation.Difficulty));
                    Console.Write("\nIf you want add next new Task - press Enter, exit - 0: ");
                    if (Console.ReadLine() == "0")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
                return tasksArrayList;
            }
        }
    }
}