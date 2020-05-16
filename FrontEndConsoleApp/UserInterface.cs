using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndConsoleApp
{
    public class UserInterface
    {
        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine(
                    "-------------------------------------------------------------\n" +
                    "  --  Welcome to Toshe Station and the Power Converters  --  \n" +
                    "-------------------------------------------------------------\n\n" +
                    "" +
                    "                --  Please select a number --                \n\n" +
                    " 1) Create a New Contract\n" +
                    " 2) View In Progress Contracts\n" +
                    " 3) View Completed or Failed Contracts\n" +
                    " 4) View List of Bounty Hunters\n" +
                    " 5) View List of Currently Available Planets\n" +
                    " 6) View List of Ships\n" +
                    " 7) View List of Weapons\n\n");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("\n\nInvalid Response. Please try again.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }
        }
    }
}
