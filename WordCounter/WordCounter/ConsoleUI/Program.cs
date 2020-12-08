using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounterLib;

/*
 * S A
 * Word Counter
 * 9.13.2020
 * CSC-253
 * 
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            int count;
            do
            {
                Console.Clear();
                StdMsg.DisplayHeader(); //header
                StdMsg.DisplayPrompt(); //prompt for string

                input = Console.ReadLine(); //get string

                NoSpaces(ref input); //remove excess spaces

                if(input.Equals("q")) //if input equals "q"
                {
                    break;            //breaks the loop. exits.
                }

                count = countWords(input); //count words, assign to count.

                StdMsg.DisplayWordCount(count); //Display count
                Console.ReadLine();
            } while (true);

        }

        public static int countWords(String input) //method accepts string as arg, returns number of words it contains
        {
            int numWords = 0; //counter starts at zero.

            if(input.Length == 0) //if the length of the string is zero
            {
                return numWords; //return zero.
            }

            String[] words = input.Split(' '); //tokenize


            for (int i = 0; i < words.Length; ++i)
            {
                ++numWords;//Count each word.
            }
            return numWords; //return number of words.
        }

        public static void NoSpaces(ref String words) //Pass string as ref
        {
            while (words.Contains("  ")) //while the string contains double spaces
            {
                words = words.Replace("  ", " "); //replace double spaces with one space.
            }
        }
    }
}
