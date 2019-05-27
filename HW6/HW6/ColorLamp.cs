using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public class ColorLamp
    {
        public int IndexNumber { get; set; }
        private int _colorsLamp;
        public int ColorsLamp
        {
            get
            {
                return _colorsLamp;
            }
            set
            {
                if (0 <= value || value > 3)
                {
                    Console.WriteLine($"{value} is not valid.");
                    _colorsLamp = 1; //set default - Red;
                    Console.WriteLine($"Set default color value: {_colorsLamp}");
                }
                else
                {
                    _colorsLamp = value;
                }

                //_colorsLamp = "Red"; //set default;

                //if (enumColorsLamp.Red.ToString().Equals(value))
                //{
                //    _colorsLamp = "Red";
                //}
                //if (enumColorsLamp.Yellow.ToString().Equals(value))
                //{
                //    _colorsLamp = "Yellow";
                //}
                //if (enumColorsLamp.Green.ToString().Equals(value))
                //{
                //    _colorsLamp = "Green";
                //}
                //if (enumColorsLamp.Blue.ToString().Equals(value))
                //{
                //    _colorsLamp = "Blue";
                //}
            }
        }

        public ColorLamp(int indexNumber, int colorsLamp)
        {
            IndexNumber = indexNumber;
            ColorsLamp = colorsLamp;
        }

        public string GetStatusLamp(bool currentEvenMinute)
        {

            if (IndexNumber % 2 == 0 ^ currentEvenMinute)
            {
                return "On";
            }
            else
            {
                return "Off";
            }
        }
        
        //public enum enumColorsLamp
        //{
        //    Red = 1,
        //    Yellow = 2,
        //    Green = 3,
        //    Blue = 4
        //}
    }
}
