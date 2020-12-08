using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Date
* CSC 153
* 3.18.2020
* Standard Messages Class
*/
namespace myClassLib
{
    public class StdMsgs
    {
        public static string DisplayMenu(bool carMade)//display proper menu.
        {
            if (!carMade)
            {
                return "1. Create-A-Car\n2. Accelerate\n3. Brake\n4. Exit";
            }
            else
            {
                return "1. Show Car\n2. Accelerate\n3. Brake\n4. Exit";
            }
        }

        public static string AskForMake()//Ask user for make of car
        {
            return "Enter your car's\n make: ";
        }

        public static string AskForYear()//ask user for year of car
        {
            return " year: ";
        }

        public static string DisplayYearError()//error prompt for year input
        {
            return "There was a problem with the year you entered.";
        }

        public static string ShowSpeed(Car carObj)//show car's speed.
        {
            return $"Your speed: {carObj.Speed}";
        }

        public static string ShowAccelPrompt()//show accelerating prompt.
        {
            return "Accelerating...";
        }

        public static string ShowBrakePrompt()//show braking prompt
        {
            return "Braking...";
        }


        public static string DisplayStopPrompt() //show complete stop prompt
        {
            return "Your car is at a complete stop.";
        }

        public static string DisplayBadInputPrompt() //show bad input prompt
        {
            return "Choose from the Menu.";
        }

        public static string ShowCar(Car aCar) //show car
        {
            return $"Your car\n------\nMake: {aCar.Make}\nYear: {aCar.Year}";
        }

        public static string NoCarPrompt() //show no car prompt
        {
            return "You haven't created a car yet.";
        }
        public static string AlreadyCarPrompt() //show already a car prompt
        {
            return "You haven't created a car yet.";
        }

    }
}
