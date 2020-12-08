using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;


/*
 * Sene Apulu
 * 08.23.2020
 * CSC 253
 * Bacteria Population Calculator.
 * M1
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double initPop, //variables
                   finalPop,
                   growthRate;
            int days;

            MyClassLib.StdMsg.DisplayTitle(); //show title

            MyClassLib.StdMsg.InitPopPrompt();
            initPop = Double.Parse(Console.ReadLine()); //Get initial Population

            MyClassLib.StdMsg.GrowthRatePrompt();
            growthRate = Double.Parse(Console.ReadLine()); //Get Rate of Growth

            MyClassLib.StdMsg.NumberOfDaysPrompt();
            int.TryParse(Console.ReadLine(), out days); //Get number of days to grow

            MyClassLib.StdMsg.DisplayHeader(); //Show Header

            for (int i = 0; i < days; ++i) 
            {
                finalPop = CalcPop(initPop, growthRate, i); //Final population for each day is calculated.
                MyClassLib.StdMsg.ShowDayAndPop(i, finalPop); //and then displayed
            }
            MyClassLib.StdMsg.EnterToEnd();
        } //end main

        public static double CalcPop(double initPop, double rate, int day) //Calculate Population for the Day.
        {
            return initPop + ((initPop * rate) * day); 
        }
    }
}
