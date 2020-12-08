using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class StdMsg
    {
        public static void DisplayTitle() //Display Title
        {
            Console.WriteLine("Organism Growth Calculator");
        }

        public static void InitPopPrompt()//Ask for intial population
        {
            Console.Write("Enter beginning population of organism: ");
        }

        public static void GrowthRatePrompt()//Ask for rate of growth
        {
            Console.Write("Enter growth rate (ex.: .5): ");
        }

        public static void NumberOfDaysPrompt() //Ask for number of days
        {
            Console.Write("Enter number of days: ");
        }

        public static void DisplayHeader() //display header
        {
            Console.WriteLine();
            Console.WriteLine($"Day".PadRight(10) + "Population");
        }

        public static void ShowDayAndPop(int day, double pop) //show day and population for that day.
        {
            Console.WriteLine($"{day + 1}".PadRight(10) + $"{pop}");
        }

        public static void EnterToEnd()
        {
            Console.WriteLine("\n[ Enter ] to exit");
            Console.ReadLine();
        }
    }
}
