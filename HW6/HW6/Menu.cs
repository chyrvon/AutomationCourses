using System;
using HW6.Helper;

namespace HW6
{
    public class UserMenu
    {
        public const int ReTry = 5;
        private int _userСhoice;
        private bool сurrentMinuteEvenOrOdd = GetCurrentMinutes.EvenOrOdd();
        protected int UserСhoice
        {
            get
            {
                return _userСhoice;
            }
            set
            {
                if (1 > value || value > 4)
                {
                    Console.WriteLine($"Input value is incorrect. Exit");
                    _userСhoice = 4;
                }
                else
                {
                    _userСhoice = value;
                }
            }
        }

        public UserMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu: \n" +
                "1. Create simple garland\n" +
                "2. Create colored garland\n" +
                "3. Create simple and colored garlands\n\n" +
                "4. Exit\n");
            Console.Write("Select: ");
            UserСhoice = GetValue.ReadValueConsoleToMenu(4);
            ProcessingMenu(UserСhoice);
        }

        public void UserSubMenu(ColorGarland colorGarland)
        {
            Console.WriteLine("\nSub-Menu:\n" +
                "1. Setting the color of the lamp in the garland\n" +
                "2. Get color of lamp in Colored Garland\n" +
                "3. Exit\n");
            Console.Write("Select: ");
            UserСhoice = GetValue.ReadValueConsoleToMenu(3);
            ProcessingSubMenu(UserСhoice, colorGarland);
        }

        private void ProcessingSubMenu(int userСhoice, ColorGarland _colorGarland)
        {
            int lengthGarland = _colorGarland._garland.Length;
            
            switch (userСhoice)
            {
                case 1:
                    //1. Set color to lamp in Colored Garland
                    Console.Write("Please enter index of lamp in Colored Garlend: ");
                    int indexLamp = GetValue.ReadValueConsoleToMenu(lengthGarland);
                    indexLamp -= 1;
                    Console.Write("\nPlease enter color: ");
                    string newColor = GetValue.ReadValueConsoleColor();
                    PrintTaskPage.StringToPrint = null;//clear Print buffer
                    _colorGarland._garland[indexLamp] = new ColorLamp(indexLamp, newColor);
                    _colorGarland.ShowStatusGarland();
                    break;
                case 2:
                    //2. Get color of lamp in Colored Garland
                    Console.Write("Please enter index of lamp in Colored Garlend: ");
                    int indexLampGetColor = GetValue.ReadValueConsoleToMenu(lengthGarland);
                    indexLampGetColor -= 1;
                    string getColor = _colorGarland._garland[indexLampGetColor].ColorsLamp;
                    Console.Write($"\nColor of lamp with index number {indexLampGetColor+1} is {getColor}\n");
                    break;
                default:
                case 3:
                    //3. Exit
                    Environment.Exit(0);
                    break;
            }
        }

        private void ProcessingMenu(int userСhoice)
        {
            bool showGarlands = false;
            SimpleGarland _simpleGarland = new SimpleGarland(1);
            ColorGarland _colorGarland = new ColorGarland(1);

            switch (userСhoice)
            {
                case 1:
                    //1. Set number of lamps to Simple Garland
                    Console.Clear();
                    Console.Write("Enter number of lamps in Simple Garland: ");
                    int lamps = GetValue.ReadValueConsoleToMenu(1000);
                    SimpleGarland simpleGarland = new SimpleGarland(lamps);
                    if (!showGarlands)
                    {
                        simpleGarland.ShowStatusGarland();
                        PrintTaskPage.PrintMenu();
                    }
                    else
                    {
                        _simpleGarland = simpleGarland;
                        goto case 2;
                    }
                    break;
                case 2:
                    //2. Set number of lamps to Color Garland
                    Console.Clear();
                    Console.Write("Enter number of lamps to Colored Garland: ");
                    lamps = GetValue.ReadValueConsoleToMenu(1000);
                    ColorGarland colorGarland = new ColorGarland(lamps);
                    if (!showGarlands)
                    {
                        colorGarland.ShowStatusGarland();
                        UserSubMenu(colorGarland);
                        PrintTaskPage.PrintMenu();
                    }
                    else
                    {
                        _colorGarland = colorGarland;
                        goto case 3;
                    }
                    break;
                case 3:
                    //3. Show garlands and Print
                    Console.Clear();
                    if (!showGarlands)
                    {
                        showGarlands = true;
                        goto case 1;
                    }
                    else
                    {
                        _simpleGarland.ShowStatusGarland();
                        _colorGarland.ShowStatusGarland();
                        PrintTaskPage.PrintMenu();
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                    }
                    break;
                case 4:
                default:
                    //4. exit
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
