using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * S Apulu
 * CSC 253
 * 9.1.2020
 * Area Class
 * Standard Msgs
 */
namespace AreaOfShapes
{
    public class StdMsgs
    {
        //Prompts

        //Menu
        public static void MenuPrompt()
        {
            Console.Write("1. Circle\n" +
                          "2. Rectangle\n" +
                          "3. Cylinder\n" +
                          "Choose: ");
        }

        //Circles
        public static void RadiusOfCirclePrompt()
        {
            Console.Write("Enter radius of circle: ");
        }

        public static void DisplayCirclArea(double circleArea)
        {
            Console.WriteLine($"The area of the circle is: {circleArea}");
        }


        //Rectangles
        public static void RectWidthPrompt()
        {
            Console.Write("Enter width of rectangle: ");
        }

        public static void RectLengthPrompt()
        {
            Console.Write("Enter length of rectangle: ");
        }

        public static void DisplayRectArea(double rectArea)
        {
            Console.WriteLine($"The area of the rectangle is: {rectArea}");
        }

        //Cylinder

        public static void CylRadiusPrompt()
        {
            Console.Write("Enter the radius of cylinder's base: ");
        }

        public static void CylHeightPrompt()
        {
            Console.Write("Enter the height of cylinder: ");
        }

        public static void DisplayCylArea(double cylArea)
        {
            Console.WriteLine($"The area of the cylinder is: {cylArea}");
        }
    }
}
