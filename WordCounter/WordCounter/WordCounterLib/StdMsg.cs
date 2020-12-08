using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * S A
 * Word Counter
 * 9.13.2020
 * CSC-253
 * 
 */
namespace WordCounterLib
{
    public class StdMsg
    {
        public static void DisplayHeader() //header
        {
            Console.WriteLine("Word Counter");
        }

        public static void DisplayPrompt() //prompt
        {
            Console.Write("\n(\"q\" to quit)" +
              "\nEnter a string: "); 
        }

        public static void DisplayWordCount(int count)
        {
            Console.WriteLine($"\nYour string has {count} word(s)." +
                              $"\n\n[ enter ] to continue\n");
        }

    }
}
