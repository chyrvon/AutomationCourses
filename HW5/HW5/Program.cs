using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            TasksArray CurrentArray = new TasksArray();
            CurrentArray.NumberTasks = new GetValue().ReadValueConsole("Please, enter number of tasks: ");
            int[,] ArrayTask = CurrentArray.InitialArray(CurrentArray.NumberTasks);

            CurrentArray.FillArray(ArrayTask);
            CurrentArray.Display(ArrayTask);

            //1 - how much time is needed to complete all tasks
            Calculation calculation = new Calculation();
            calculation.AllTime(ArrayTask);

            //2 - list of tasks of a given priority
            new ShowTaskPriority(new GetValue().ReadValueConsole("Enter priority for build list: ", true), ArrayTask);

            //3 - what tasks can be done in N days based on priority
            calculation.TaskCanBeDone(ArrayTask);

            //4 - print
            new PrintTaskPage();
            Console.ReadKey();
        }
    }
}


