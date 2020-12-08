using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumGen
{
    public class StdMsg
    {
        public static void HowManyPrompt()
        {
            Console.Write("How many random integers do you want to generate? ");
        }
        
        public static void ShowRandomInt(Random rnd)
        {
            Console.WriteLine(rnd.Next(1, 101).ToString());
        }

        public static void DonePrompt()
        {
            Console.WriteLine("Done.");
        }

        public static void Stop()
        {
            Console.ReadLine();
        }

        public static void TryAgainPrompt()
        {
            Console.WriteLine("Try again.");
        }
    }
}
