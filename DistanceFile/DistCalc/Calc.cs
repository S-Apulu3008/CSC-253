using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* SA
 * 9.21.2020
 * CSC-253
 * Distance File Writer
 */

namespace DistCalc
{
    public class Calc
    {
        public static double DistanceTravled(double speed, double time) //Calculate Distance Travelled.
        {
            return speed * time;
        }

        public static double GetSpeed() //Get the speed.
        {
            StdMsg.AskForSpeed();
            do
            {
                if (Double.TryParse(Console.ReadLine(), out double input))
                {
                    return input;
                }
                else
                {
                    StdMsg.TryAgainPrompt();
                    StdMsg.AskForSpeed();
                    continue;
                }
            } while (true);
        }
        public static double GetTime() //Get the amount of time travelled.
        {
            StdMsg.AskForTimeTrav();
            do
            {
                if (Double.TryParse(Console.ReadLine(), out double input))
                {
                    return input;
                }
                else
                {
                    StdMsg.TryAgainPrompt();
                    StdMsg.AskForTimeTrav();
                    continue;
                }
            } while (true);
        }
    }
}
