using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
/*
* Date
* CSC 153
* 3.18.2020
* Build Car Class
*/
namespace myClassLib
{
    public class BuildCar
    {
        public static void BuildACar(Car userCar)
        {
            Console.Write(StdMsgs.AskForMake());
            userCar.Make = Console.ReadLine();
            Console.Write(StdMsgs.AskForYear());
            int.TryParse(Console.ReadLine(), out int year);
            userCar.Year = year;
        }

        public static int ConvToInt(string input)
        {
            if (int.TryParse(input, out int output))
            {
                return output;
            }
            else 
            {
                output = -1;
                return output;
            }
        }
    }
}
