using System;

namespace HW6
{
    public class UserMenu
    {
        public const int ReTry = 5;
        private int _userСhoice;
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
            Console.WriteLine(@"Menu:\n" +
                "1. Set number of lamps to Simple Garland and show\n" +
                "2. Set number of lamps to Colored Garland and show\n" +
                "3. Show garlands and print\n\n" +
                "4. Exit\n");
            Console.Write("Select: ");
            UserСhoice = new GetValue().ReadValueConsoleToMenu(4);
            ProcessingMenu(UserСhoice);
        }

        public void UserSubMenu(ColorGarland colorGarland)
        {
            Console.WriteLine("\nSub-Menu:\n" +
                "1. Set color to lamp in Colored Garland\n" +
                "2. Get color of lamp in Colored Garland\n" +
                "3. Exit\n");
            Console.Write("Select: ");
            UserСhoice = new GetValue().ReadValueConsoleToMenu(3);
            ProcessingSubMenu(UserСhoice, colorGarland);
        }

        private void ProcessingSubMenu(int userСhoice, ColorGarland _colorGarland)
        {
            switch (userСhoice)
            {
                case 1:
                    //1. Set color to lamp in Colored Garland
                    Console.Write("Please enter index of lamp in Colored Garlend: ");
                    int indexLamp = new GetValue().ReadValueConsoleToMenu(_colorGarland._garland.Length);
                    indexLamp -= 1;
                    Console.Write("\nPlease enter color: ");
                    string newColor = new GetValue().ReadValueConsoleColor();
                    PrintTaskPage.StringToPrn = "";//clear Print buffer
                    _colorGarland.Garlands[indexLamp] = new ColorLamp(indexLamp, newColor);
                    _colorGarland.ShowStatusGarland(new GetCurrentMinutes().CurrentMinutes());
                    break;
                case 2:
                    //2. Get color of lamp in Colored Garland
                    Console.Write("Please enter index of lamp in Colored Garlend: ");
                    int indexLampGetColor = new GetValue().ReadValueConsoleToMenu(_colorGarland._garland.Length);
                    indexLampGetColor -= 1;
                    string getColor = _colorGarland.Garlands[indexLampGetColor].ColorsLamp;
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
                    ////1. Set number of lamps to Simple Garland
                    Console.Clear();
                    Console.Write("Enter number of lamps in Simple Garland: ");
                    int lamps = new GetValue().ReadValueConsoleToMenu(1000);
                    SimpleGarland simpleGarland = new SimpleGarland(lamps);
                    if (!showGarlands)
                    {
                        simpleGarland.ShowStatusGarland(new GetCurrentMinutes().CurrentMinutes());
                        new PrintTaskPage().PrintMenu();
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
                    lamps = new GetValue().ReadValueConsoleToMenu(1000);
                    ColorGarland colorGarland = new ColorGarland(lamps);
                    if (!showGarlands)
                    {
                        colorGarland.ShowStatusGarland(new GetCurrentMinutes().CurrentMinutes());
                        UserSubMenu(colorGarland);
                        new PrintTaskPage().PrintMenu();
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
                        _simpleGarland.ShowStatusGarland(new GetCurrentMinutes().CurrentMinutes());
                        _colorGarland.ShowStatusGarland(new GetCurrentMinutes().CurrentMinutes());
                        new PrintTaskPage().StartPrint();
                        Console.WriteLine("Press enter to exit");
                        Console.ReadLine();
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
