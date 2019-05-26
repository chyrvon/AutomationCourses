using System;

namespace HW5
{
    public class TasksArray
    {
        private protected int _numberTasks;
        public int NumberTasks
        {
            get
            {
                return _numberTasks;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"{value} is not valid.");
                    _numberTasks = Constants.DefaultNumerTasks;
                    Console.WriteLine($"Set default value: {_numberTasks}");
                }
                else
                {
                    _numberTasks = value;
                }
            }
        }

        private protected int _priority;
        private int Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                if (value <= 0 || value > 3)
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

        private protected int _difficult;
        private int Difficult
        {
            get
            {
                return _difficult;
            }
            set
            {
                if (value <= 0 || value > 3)
                {
                    Console.WriteLine($"{value} is not valid.");
                    _difficult = new Random().Next(1, 3);
                    Console.WriteLine($"Set random value: {_difficult}");
                }
                else
                {
                    _difficult = value;
                }
            }
        }

        public int[,] InitialArray(int numberTasks)
        {
            int[,] arrayTask = new int[numberTasks, 4]; //4 [NumTask, Priority, Difficult, Time]
            return arrayTask;
        }

        public void FillArray(int[,] ArrayTask)
        {
            //Structure ArrayTask: NumTask, Priority, Difficult, Time
            GetValue getValue = new GetValue();
            for (int i = 0; i < ArrayTask.GetLength(0); i++)
            {
                Priority = getValue.ReadValueConsole($"Enter priority for Task {i + 1}", true);
                Difficult = getValue.ReadValueConsole($"Enter difficult for Task {i + 1}", false);
                ArrayTask[i, 1] = Priority;
                ArrayTask[i, 2] = Difficult;

                //Time
                switch (ArrayTask[i, 2])
                {
                    case 1:
                        ArrayTask[i, 3] = Constants.TimeHard;
                        break;
                    case 2:
                        ArrayTask[i, 3] = Constants.TimeMedium;
                        break;
                    case 3:
                        ArrayTask[i, 3] = Constants.TimeEasy;
                        break;
                    default:
                        Console.WriteLine("Current task have wrong difficult! Terminate programm...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                }
                //number of current task
                ArrayTask[i, 0] = i + 1;
                Console.Clear();
            }
        }

        public void Display(int[,] arrayTask)
        {
            Console.Clear();
            string priority = "", difficult = "";
            Console.WriteLine("Tasks\t Priority\t Difficult\t Time");
            for (int j = 0; j < arrayTask.GetLength(0); j++)
            {
                switch (arrayTask[j, 1])
                {
                    case 1:
                        priority = Constants.PriorityHigh + "    ";
                        break;
                    case 2:
                        priority = Constants.PriorityMed + "    ";
                        break;
                    case 3:
                        priority = Constants.PriorityLow + "    "; ;
                        break;
                    default:
                        break;
                }

                switch (arrayTask[j, 2])
                {
                    case 1:
                        difficult = Constants.DifficultHard;
                        break;
                    case 2:
                        difficult = Constants.DifficultMed;
                        break;
                    case 3:
                        difficult = Constants.DifficultEasy;
                        break;
                }
                Console.WriteLine($"{arrayTask[j, 0]}\t {priority}\t {difficult}\t \t {arrayTask[j, 3]}");
            }
        }
    }
}
