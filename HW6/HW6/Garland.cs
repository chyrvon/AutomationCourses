using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public abstract class Garland
    {
        private const int _defaultNumberOfLamps = 10;


        public Lamp[] _garland;
        

        public Garland(int garlandLength)
        {
            _garland = new Lamp[garlandLength];
        }

        



        //public class Lamps
        //{
        //    private int _numberOfLamps;
        //    public int NumberOfLamps
        //    {
        //        get
        //        {
        //            return _numberOfLamps;
        //        }
        //        set
        //        {
        //            if (value <= 0)
        //            {
        //                Console.WriteLine($"{value} is not valid.");
        //                _numberOfLamps = _defaultNumberOfLamps;
        //                Console.WriteLine($"Set default value: {_numberOfLamps}");
        //            }
        //            else
        //            {
        //                _numberOfLamps = value;
        //            }
        //        }
        //    }
        //    public bool[] StateOfLamps;
        //}

        //public class ColorLamps
        //{
        //    private int _numberOfLamps;
        //    public int NumberOfLamps
        //    {
        //        get
        //        {
        //            return _numberOfLamps;
        //        }
        //        set
        //        {
        //            if (value <= 0)
        //            {
        //                Console.WriteLine($"{value} is not valid.");
        //                _numberOfLamps = _defaultNumberOfLamps;
        //                Console.WriteLine($"Set default value: {_numberOfLamps}");
        //            }
        //            else
        //            {
        //                _numberOfLamps = value;
        //            }
        //        }
        //    }


        //}
    }
}
