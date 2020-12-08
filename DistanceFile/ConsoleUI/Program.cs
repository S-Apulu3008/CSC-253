using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistCalc;
using System.IO;

/*
 * SA
 * CSC-253
 * 10.1.2020
 * Distance File Writer
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer; //Streamwriter obj
            writer = File.CreateText("../../DistTrav.txt"); //Open text file. Same folder as Program.cs
            double speed, time, dist; //variables
            StdMsg.Header(); //Menu

            speed = Calc.GetSpeed();//get speed

            time = Calc.GetTime();//get time

            dist = Calc.DistanceTravled(speed, time); //calc dist

            StdMsg.ShowDistTravled(dist);//show dist
            StdMsg.WriteDistTravled(writer, dist); //write dist to file
            writer.Close(); //close file
            Console.ReadLine();
        }
    }
}
