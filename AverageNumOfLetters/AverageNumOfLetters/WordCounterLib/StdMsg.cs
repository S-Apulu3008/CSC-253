using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * S A
 * 9.12.2020
 * CSC-253
 * Avg letters per word.
 */

namespace WordCounterLib
{
    public class StdMsg
    {
        public static void DisplayHeader() //header
        {
            Console.WriteLine("Word Counter and Average Letters Per Word.");
        }

        public static void DisplayPrompt() //prompt
        {
            Console.Write("\n(\"q\" to quit)" +
              "\nEnter a string: "); 
        }

        public static void DisplayWordCount(int count)
        {
            Console.WriteLine($"\nYour string has {count} word(s).\n");
        }

        public static void DisplayAvgLetters(double avgLetters)
        {
            Console.WriteLine($"Average letters per word: {avgLetters:N}" +
                              $"\n\n[ enter ] to continue\n");
        }

    }
}
