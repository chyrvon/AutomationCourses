﻿using System;
using System.Collections.Generic;
using System.Linq;
using HW5.Enums;
using HW5.Helper;
namespace HW5
{
    public class TaskManager
    {
        private int _nDayDoneTasks;
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
            int value = tasksArrayList.Select(x => x.Duration).Sum();
            string addInfo = $"\nTime needed for complete all Tasks, h: {value}";
            Console.WriteLine(addInfo);
            PrintTaskPage.StringToPrint += addInfo;
        }

        public int TimeAfterTask(Enum intPriority, int timeLeft, List<Task> tasksArrayList)
        {
            List<Task> responseTasksFromListByPriority = new List<Task>();
            responseTasksFromListByPriority.AddRange(tasksArrayList.Where(x => x.Priority.Equals(intPriority)).ToList());

            if (timeLeft > 0)
            {
                int tmpTime;
                for (int i = 0; i < responseTasksFromListByPriority.Count; i++)
                {
                        tmpTime = timeLeft;
                        tmpTime -= responseTasksFromListByPriority[i].Duration;
                        if (tmpTime >= 0)
                        {
                            timeLeft = tmpTime;
                            string addInfo = $"\n Task {responseTasksFromListByPriority[i].Number} - {responseTasksFromListByPriority[i].Duration} h";
                            Console.Write(addInfo);
                            PrintTaskPage.StringToPrint += addInfo;
                        }  
                }
            }
            return timeLeft;
        }

        public void TasksCanBeDone(List<Task> tasksArrayList)
        {
            nDayDoneTasks = new GetValue().ReadValueFromConsole("\nEnter value of days for completed all tasks: ");

            Console.Write($"\nIt is possible to perform the following tasks in {nDayDoneTasks} days: ");
            PrintTaskPage.StringToPrint += $"\nIt is possible to perform the following tasks in {nDayDoneTasks} days: ";

            int timeLeft = nDayDoneTasks * Constants.WorkHours;
            for (int i = 1; i <= Enum.GetNames(typeof(Priority)).Length; i++)
            {
                if (timeLeft > 0)
                {
                    timeLeft = TimeAfterTask((Priority)i, timeLeft, tasksArrayList);
                    if (i == 3) Console.Write($"\nLeft time: {timeLeft} h");
                }
                else break;
            }
        }

        public List<Task> SortListTasks(List<Task> tasksList)
        {
            return tasksList
                .OrderBy(x => x.Priority)
                .ThenBy(x => x.Difficulty).ToList();
        }

        //public List<Task> SortListTasks(List<Task> tasksList)
        //{
        //    List<Task> sortedTasksList = new List<Task>();
        //    for (int x = 1; x <= Enum.GetNames(typeof(Priority)).Length; x++)
        //    {
        //        for (int y = 1; y <= Enum.GetNames(typeof(Difficulty)).Length; y++)
        //        {
        //            sortedTasksList.AddRange(tasksList.Where(index => index.Priority.Equals((Priority)(x)) &&
        //                index.Difficulty.Equals((Difficulty)(y))).ToList());
        //        }
        //    }
        //    return sortedTasksList;
        //}

        public List<Task> AddNewTasks(List<Task> tasksArrayList)
        {
            for (int i = 1; i < Constants.MaxTasks; i++)
            {
                Task validation = new Task();
                DisplayConsoleMessage<Priority>($"Enter {typeof(Priority).Name.ToLower()} for Task {i} (");
                validation.Priority = GetValue.ValidationValue<Priority>();
                DisplayConsoleMessage<Difficulty>($"Enter {typeof(Difficulty).Name.ToLower()} for Task {i} (");
                validation.Difficulty = GetValue.ValidationValue<Difficulty>();
                tasksArrayList.Add(new Task(i, validation.Priority, validation.Difficulty));
                Console.Write("\nIf you want add next new Task - press Enter, exit - 0: ");
                if (Console.ReadLine() == "0")
                {
                    break;
                }
                Console.Clear();
            }
            return tasksArrayList;
        }

        public void DisplayConsoleMessage<TEnum>(string message) where TEnum : struct
        {
            Console.Write(message);
            int priorityLenght = Enum.GetNames(typeof(TEnum)).Length;
            for (int y = 1; y <= priorityLenght; y++)
            {
                Console.Write($"{y} - {Enum.GetName(typeof(TEnum), y)}");
                if (y < priorityLenght) Console.Write(", ");
                else Console.Write("): ");
            }
        }
    }
}
