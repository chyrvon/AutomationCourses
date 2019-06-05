using System;
using System.Collections.Generic;
using HW5.Enums;
namespace HW5
{
    public class Task
    {
        private int _number;
        private string _priority;
        private string _difficulty;
        private int _duration;
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value <= 0 && value > 10000)
                {
                    _number = 1;
                }
                _number = value;
            }
        }
        public string Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                for (int _reTry = 1; _reTry <= Constants.ReTry; _reTry++)
                {
                    if (_reTry > 1)
                    {
                        value = Console.ReadLine();
                    }
                    if (Enum.TryParse(value, true, out PriorityEnum result))
                    {
                        _priority = result.ToString();
                        break;
                    }
                    else
                    {
                        if (_reTry != Constants.ReTry)
                        {
                            Console.Write($"The entered value is not valid. "
                            + $"Attempts left: {Constants.ReTry - _reTry}. Try again: ");
                        }
                        else
                        {
                            Console.WriteLine($"Set default priority: {PriorityEnum.Low}");
                            _priority = PriorityEnum.Low.ToString(); //default
                        }
                    }
                }
            }
        }
        public string Difficulty
        {
            get
            {
                return _difficulty;
            }
            set
            {
                for (int _reTry = 1; _reTry <= Constants.ReTry; _reTry++)
                {
                    if (_reTry > 1) value = Console.ReadLine();
                    if (Enum.TryParse(value, true, out DifficultyListEnum result))
                    {
                        _difficulty = result.ToString();
                        break;
                    }
                    else
                    {
                        if (_reTry != Constants.ReTry)
                        {
                            Console.Write($"The entered value is not valid. "
                            + $"Attempts left: {Constants.ReTry - _reTry}. Try again: ");
                        }
                        else
                        {
                            Console.WriteLine($"Set default priority: {DifficultyListEnum.Easy}");
                            _difficulty = DifficultyListEnum.Easy.ToString(); //default
                        }
                    }
                }
            }
        }
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (value <= 0 && value > 4)
                {
                    _duration = 1;
                }
                _duration = value;
            }
        }

        public Task()
        {
        }

        public Task(int numTask, string priority, string difficult)
        {
            Number = numTask;
            Priority = priority;
            Difficulty = difficult;

            DifficultyEnum listDifficult;
            Enum.TryParse(Difficulty, true, out listDifficult);
            Duration = (int)listDifficult;
        }

        public void Display(List<Task> tasksArrayList)
        {
            //Console.Clear();
            Console.WriteLine("Tasks\t Priority\t Difficult\t Time");
            tasksArrayList.ForEach(x => Console.WriteLine($"{x.Number,-3} \t {x.Priority,-10} " +
            $"\t {x.Difficulty,-12} \t {x.Duration,-12}"));
        }
    }
}
