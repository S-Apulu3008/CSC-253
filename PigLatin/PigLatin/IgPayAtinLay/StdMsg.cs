using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * S A
 * CSC-253
 * 9.16.2020
 * Plaintext to Pig Latin
 * 
 */

namespace IgPayAtinLay
{
    public class StdMsg
    {
        //prompts
        public static void DisplayHeader()
        {
            Console.WriteLine("Plaintext to PigLatin" +
                            "\n---------------------");
        }

        public static void AskForStringPrompt()//ask for string
        {
            Console.Write("Enter plaintext: (q to quit): ");
        }

        public static void TryAgainPrompt()//try again
        {
            Console.WriteLine("Try again...");
        }

        public static void ContinuePrompt()//continue
        {
            Console.Write("[ enter ] to continue...");
        }

        public static void DisplayPigLatin(String pigLatin)//display PigLatinized string
        {
            Console.WriteLine("\nTo PigLatin: ");
            Console.WriteLine(pigLatin);
            Console.WriteLine();
        }

        public static void Clear()//clear screen
        {
            Console.Clear();
        }

        public static void Stop() //Stop
        {
            Console.ReadLine();
        }
    }
}
