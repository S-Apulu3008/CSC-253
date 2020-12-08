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
 * AreaOf Class
 */

namespace AreaOfShapes
{
    public class AreaOf
    {   //Calculations
        public static double CalcArea(double radius)
        {
            return Math.PI * (radius * radius);//Circle's area
        }

        public static double CalcArea(double width, double length)
        {
            return width * length;//Rectangle's area
        }

        public static double CalcArea(double radius, double height, double pi)
        {
            return 2 * pi * (radius * radius) + height * (2 * pi * radius);//Cylinder's area
        }
    }
}
