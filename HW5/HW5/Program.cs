using System;
using System.Drawing;
using System.Drawing.Printing;

namespace CustomMethods
{  
    static class Constants
    {
        public const int MaxValueArray = 50; // max Tasks
        public const string PriorityHigh = "Высокий";
        public const string PriorityMed = "Средний";
        public const string PriorityLow = "Низкий";
        public const string DifficultHard = "Сложная";
        public const string DifficultMed = "Средняя";
        public const string DifficultEasy = "Легкая ";
        public const int TimeHard = 4;
        public const int TimeMed = 2;
        public const int TimeEasy = 1;
    }

    public static class Array
    { 
       public static int Print(int[,] ArrayTask)
        {
            Console.Clear();
            string Priority = "", Difficult = "";
            Console.WriteLine("Задачи\t Приоритет\t Сложность\t Время");
            for (int j = 0; j < Constants.MaxValueArray; j++)
            {
                switch (ArrayTask[j, 1])
                {
                    case 1:
                        Priority = Constants.PriorityHigh + "  ";
                        break;
                    case 2:
                        Priority = Constants.PriorityMed + "    ";
                        break;
                    case 3:
                        Priority = Constants.PriorityLow + "    "; ;
                        break;
                    default:
                        goto EndPrint;
                }

                switch (ArrayTask[j, 2])
                {
                    case 1:
                        Difficult = Constants.DifficultHard;
                        break;
                    case 2:
                        Difficult = Constants.DifficultMed;
                        break;
                    case 3:
                        Difficult = Constants.DifficultEasy;
                        break;
                }
                Console.WriteLine($"{ArrayTask[j, 0]}\t {Priority}\t {Difficult}\t {ArrayTask[j, 3]}");
            }
            EndPrint:
            return 0;
        }
       public static int FillArray(int[,] ArrayTask)
       {
            int tmp;
            for (int i = 0; i < Constants.MaxValueArray; i++)
            {
                //ArrayTask [NumTask, Priority, Difficult, Time]

                //Priority
                tmp = EnterValuePriority(i, false);
                if (tmp == 0) break; //конец ввода
                else ArrayTask[i, 1] = tmp;

                //Difficult
                ArrayTask[i, 2] = EnterValueDifficult(i);

                //Time
                switch (ArrayTask[i, 2])
                {
                    case 1:
                        ArrayTask[i, 3] = Constants.TimeHard;
                        break;
                    case 2:
                        ArrayTask[i, 3] = Constants.TimeMed;
                        break;
                    case 3:
                        ArrayTask[i, 3] = Constants.TimeEasy;
                        break;
                }

                //number of current task
                ArrayTask[i, 0] = i+1;

                Console.Clear();
            }
            return 0;
       }
       public static int EnterValuePriority(int i, bool SetPriorityToShowList)
       {
            int Value = 0;
            string tmpValue = "";
            if (i > 0 ) Console.Write("Чтобы завершить ввод, введите end\n");
            if (SetPriorityToShowList == false) Console.Write($"Введите приоритет для Задачи {i+1}, (1 - {Constants.PriorityHigh}, 2 - {Constants.PriorityMed}, 3 - {Constants.PriorityLow}): ");
            else Console.Write($"\nВведите приоритет для построения списка (1 - {Constants.PriorityHigh}, 2 - {Constants.PriorityMed}, 3 - {Constants.PriorityLow}): ");
            RetryEnterLengthSide:

            tmpValue = Console.ReadLine();
            try
            {
                Value = Convert.ToInt32(tmpValue);
                if ((Value < 1) | (Value > 3))
                {
                    Console.Write("Введено не валидное значение, повторите ввод: ");
                    goto RetryEnterLengthSide;
                }
            }
            catch
            {
                tmpValue = tmpValue.ToLower();
                if (tmpValue.Length > 0)
                    tmpValue = tmpValue.Substring(0, 1).ToUpper() + tmpValue.Substring(1, tmpValue.Length - 1); //первуя буква заглавная
                switch (tmpValue)
                {
                    case Constants.PriorityHigh:
                        Value = 1;
                        break;
                    case Constants.PriorityMed:
                        Value = 2;
                        break;
                    case Constants.PriorityLow:
                        Value = 3;
                        break;
                    case "End":
                        return Value;
                    default:
                        Console.Write("Введено не валидное значение, повторите ввод: ");
                        goto RetryEnterLengthSide;
                }
            }
            return Value;
       }
       public static int EnterValueDifficult(int i)
       {
            int Value;
            string tmpValue = "";
            Console.Write($"Введите сложность Задачи {i+1}, (1 - Сложная, 2 - Средняя, 3 - Легкая): ");
        RetryEnterLengthSide:

            tmpValue = Console.ReadLine();
            try
            {
                Value = Convert.ToInt32(tmpValue);
                if ((Value < 1) | (Value > 3))
                {
                    Console.Write("Введено не валидное значение, повторите ввод: ");
                    goto RetryEnterLengthSide;
                }
            }
            catch
            {
                tmpValue = tmpValue.ToLower();
                switch (tmpValue)
                {
                    case "Сложная":
                        Value = 1;
                        break;
                    case "Средняя":
                        Value = 2;
                        break;
                    case "Легкая":
                        Value = 3;
                        break;
                    default:
                        Console.Write("Введено не валидное значение, повторите ввод: ");
                        goto RetryEnterLengthSide;
                }
            }
            return Value;
       }
       public static int ShowTaskPriority(int Priority, int[,] ArrayTask)
       {
            switch (Priority)
            {
                case 1:
                    Console.Write($"\nСписок задач с приоритетом {Constants.PriorityHigh}:");
                    Сalculation.ToPrn += $"\nСписок задач с приоритетом {Constants.PriorityHigh}:";
                    break;
                case 2:
                    Console.Write($"\nСписок задач с приоритетом {Constants.PriorityLow}:");
                    Сalculation.ToPrn += $"\nСписок задач с приоритетом {Constants.PriorityLow}:";
                    break;
                case 3:
                    Console.Write($"\nСписок задач с приоритетом {Constants.PriorityLow}:");
                    Сalculation.ToPrn += $"\nСписок задач с приоритетом {Constants.PriorityLow}:";
                    break;
            }
            for (int i = 0; i < Constants.MaxValueArray; i++)
            {
                if (ArrayTask[i, 1] == Priority)
                {
                    Console.Write($"\nЗадача {ArrayTask[i, 0]}");
                    Сalculation.ToPrn += $"\nЗадача {ArrayTask[i, 0]}";
                }
            }
            return 0;          
       }  
    }

    public class Сalculation
    {
        public static string ToPrn = "";
        public static int AllTime(int[,] ArrayTask)
        {
            int Value = 0;
            for (int i = 0; i <= Constants.MaxValueArray; i++)
            {
                if (ArrayTask[i, 0] > 0) Value = Value + ArrayTask[i, 3];
                else break;
            }
            Console.Write($"\nВсего времени нужно для выполнения всех задач, ч: {Value}");
            ToPrn += $"\nВсего времени нужно для выполнения всех задач, ч: {Value}";
            return Value;
        }

        public static int TimeAfterTask(int Priority, int TimeLeft, int[,] ArrayTask)
        {
            if (TimeLeft > 0)
            {                
                int tmpTime;
                for (int i = 0; i < Constants.MaxValueArray; i++)
                {
                    if (ArrayTask[i, 1] == Priority)
                    {
                        tmpTime = TimeLeft;
                        tmpTime = tmpTime - ArrayTask[i, 3];
                        if (tmpTime >= 0)
                        {
                            TimeLeft = tmpTime;
                            Console.Write($"\n Задача {ArrayTask[i, 0]}");
                            ToPrn += $"\n Задача { ArrayTask[i, 0]}";
                        }                        
                    }
                }
            }            
            return TimeLeft;
        }
        
        public static void PrintDPF()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);
            printDocument.Print();
        }

        private static void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ToPrn, new Font("Arial", 14), Brushes.Black, 0, 0);
            
        }
    }
}

namespace HW_Task5
{
    using CustomMethods;
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayTask [NumTask, Priority, Difficult, Time]
            int[,] ArrayTask = new int[Constants.MaxValueArray, 4];

            //заполним массив задачами
            Array.FillArray(ArrayTask);

            //выведем на экран список задач (массив)
            Array.Print(ArrayTask);

            //1 - сколько всего времени нужно для выполнения всех задач
            Сalculation.AllTime(ArrayTask);

            //2 - список задач заданного приоритета (приоритет ввести с клавиатуры)
            int Priority = Array.EnterValuePriority(0, true);
            Array.ShowTaskPriority(Priority, ArrayTask);

            //3 - какие задачи возможно сделать за N дней с учетом приоритета(N ввести с клавиатуры)
            Console.Write("\nВведите кол-во дней для выполнения задач: ");
            int Nday = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\nЗа {Nday} дней возможно выполнить следующие задачи: ");
            Сalculation.ToPrn += $"\nЗа {Nday} дней возможно выполнить следующие задачи: ";

            int TimeLeft = Nday * 24;
            for (int i = 1; i < 4; i++)
            {
                if (TimeLeft > 0)
                {
                    TimeLeft = Сalculation.TimeAfterTask(i, TimeLeft, ArrayTask);
                    if (i == 3) Console.Write($"\nОстанется времени: {TimeLeft} ч");
                }
                else break;
            }
            Сalculation.PrintDPF();
            Console.ReadKey();
        }
    }
}


