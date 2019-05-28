using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (1 > value || value > 7)
                {
                    Console.WriteLine($"Input value is incorrect. Exit");
                    _userСhoice = 7;
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
            Console.WriteLine("Menu:\n" +
                "1. Set number of lamps to Simple Garland\n" +
                "2. Set number of lamps to Color Garland\n" +
                "3. Set color to lamp(index)\n" +
                "4. Get color of lamp(index)\n" +
                "5. Print status of garland\n" +
                "6. Show garlands\n\n" +
                "7. Exit");

            UserСhoice = new GetValue().ReadValueConsoleToMenu();
            ProcessingMenu(UserСhoice);

            

        }

        private int ProcessingMenu(int userСhoice)
        {

            switch (userСhoice)
            {
                case 1:
                    Console.Clear();
                    //1. Set number of lamps to Simple Garland
                    Console.Write("Enter number of lamps in Simple Garland: ");
                    int lamps = new GetValue().ReadValueConsoleInt();

                    //get current time
                    //string currentMinutes = DateTime.Now.ToShortTimeString();
                    //Console.WriteLine($"Current time: {currentMinutes}");
                    //Int32.TryParse(currentMinutes.Substring(currentMinutes.Length - 1), out int lastNumberMinute);

                    SimpleGarland simpleGarland = new SimpleGarland(lamps);
                    simpleGarland.PrintStatusGarland(new GetCurrentMinutes().CurrentMinutes());
                    Console.ResetColor();
                    Console.ReadLine();
                    //TODO return to MENU


                    break;
                case 2:
                    //2. Set number of lamps to Color Garland
                    break;
                case 3:
                    //3. Set color to lamp(index)
                    break;
                case 4:
                    //4. Get color of lamp(index)
                    break;
                case 5:
                    //5. Print status of garland
                    break;
                case 6:
                    //6. Show garlands
                    break;

            }
            return 5;
        }

    }
}
