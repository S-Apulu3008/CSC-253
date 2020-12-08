using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/* SA
 * 9.21.2020
 * CSC-253
 * Distance File Writer
 */

namespace DistCalc
{
    public class StdMsg
    {
        public static void Header()
        {
            Console.WriteLine("Distance Traveled Calculator\n" +
                              "_.-=-._.-=-._.-=-._.-=-._.-=-._\n");
        }
        public static void AskForSpeed()
        {
            Console.Write("Enter speed: ");
        }

        public static void AskForTimeTrav()
        {
            Console.Write("Enter time traveled: ");
        }

        public static void ShowDistTravled(double dist)
        {
            Console.WriteLine($"Distance traveled: {dist:N1} miles");
        }

        public static void WriteDistTravled(StreamWriter writer, double dist)
        {
            writer.WriteLine("Distance traveled: " + dist.ToString() + " miles"); //write dist to file
        }

        public static void ContinuePrompt()
        {
            Console.WriteLine("Type \"q\" to quit or [enter] to continue");
        }

        public static void TryAgainPrompt()
        {
            Console.WriteLine("Try again.\n");
        }
    }
}
