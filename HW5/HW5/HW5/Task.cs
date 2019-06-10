using System;
using System.Collections.Generic;
using HW5.Enums;
using HW5.Helper;
namespace HW5
{
    public class Task
    {
        private int _number;
        private Enum _priority;
        private Enum _difficulty;
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
        public Enum Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                _priority = value;
            }
        }
        public Enum Difficulty
        {
            get
            {
                return _difficulty;
            }
            set
            {
                _difficulty = value;
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
                if (value <= 0 || value > 4)
                {
                    _duration = 1;
                }
                _duration = value;
            }
        }

        public Task()
        {
        }

        public Task(int numTask, Enum priority, Enum difficult)
        {
            Number = numTask;
            Priority = priority;
            Difficulty = difficult;

            Difficulty listDifficult;
            Enum.TryParse(Difficulty.ToString(), true, out listDifficult);
            Duration = int.Parse(EnumsHelper.GetDescription(listDifficult));

        }

        public override string ToString()
        {
            return $"{Number,-3} \t {Priority,-10} \t {Difficulty,-12} \t {Duration,-12}";
        }

            
    }
}
