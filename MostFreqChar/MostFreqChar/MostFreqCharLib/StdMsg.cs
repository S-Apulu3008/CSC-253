using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * S A
 * CSC-253
 * 9.16.2020
 */

namespace MostFreqCharLib
{
    public class StdMsg //Standard messages class
    {
        public static void AskForStringPrompt() 
        {
            Console.Write("Enter a string(\'*\' to exit): ");
        }

        public static void TryAgainPrompt()
        {
            Console.WriteLine("\nTry again.");
        }

        public static void MostFreqCharPrompt(char ch)
        {
            Console.WriteLine($"\n{ch} is the most frequent character in your string.");
        }

        public static void End()
        {
            Console.Write("\n[enter] to continue");
            Console.ReadLine();
        }

        public static void Clear() 
        {
            Console.Clear();
        }
    }
}
