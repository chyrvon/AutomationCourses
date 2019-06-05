using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class AddNewTask
    {
        public List<TasksArrayList> AddNewTasks(List<TasksArrayList> tasksArrayList)
        {
            GetValue getValue = new GetValue();
            for (int i = 1; i < 1000; i++)
            {
                string Priority = getValue.ReadValueConsoleString($"Enter priority for Task {i}", true);
                string Difficult = getValue.ReadValueConsoleString($"Enter difficult for Task {i}", false);
                tasksArrayList.Add(new TasksArrayList(i, Priority, Difficult));
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
