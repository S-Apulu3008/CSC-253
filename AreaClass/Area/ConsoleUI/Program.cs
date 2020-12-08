using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaOfShapes; //Using class library

/*
 * S Apulu
 * CSC 253
 * 9.1.2020
 * Area Class
 * Main
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double cirArea,
                   rectArea,
                   cylArea,
                   width,
                   radius,
                   length,
                   height,
                   pi = Math.PI;

            StdMsgs.MenuPrompt();//display menu
            switch(Console.ReadLine()) //switch user choice
            {
                case "1"://Circle option
                    StdMsgs.RadiusOfCirclePrompt();
                    radius = ProcureDouble(); //Get radius of circle
                    cirArea = AreaOf.CalcArea(radius); //calculate area of circle
                    StdMsgs.DisplayCirclArea(cirArea); //display area of circle
                    break;
                case "2"://Rectangle option
                    StdMsgs.RectWidthPrompt();
                    width = ProcureDouble(); //get width of rectangle.
                    StdMsgs.RectLengthPrompt();
                    length = ProcureDouble(); //get length of rectangle.
                    rectArea = AreaOf.CalcArea(width, length); //calculate area of rectangle
                    StdMsgs.DisplayRectArea(rectArea);//display area of rectangle
                    break;
                case "3"://Cylinder option
                    StdMsgs.CylRadiusPrompt();
                    radius = ProcureDouble(); //get radius of cylinder
                    StdMsgs.CylHeightPrompt();
                    height = ProcureDouble();//get height of cylinder
                    cylArea = AreaOf.CalcArea(radius, height, pi);//calculate area of cylinder
                    StdMsgs.DisplayCylArea(cylArea); //display area of cylinder
                    break;
                default:
                    break;
            }//end switch

            Console.Write("Done.");
            Console.ReadLine();
        }//End Main

        public static double ProcureDouble()
        {
            double number;
            do
            {
                if (Double.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                else
                {
                    Console.Write("Try again.\n>");
                    continue;
                }
            } while (true);
        }
    }
}
