using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounterLib; 

/*
 * S A
 * 9.12.2020
 * CSC-253
 * Avg letters per word.
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int count;
            double avgLetters;
            do
            {
                Console.Clear();
                StdMsg.DisplayHeader(); //header
                StdMsg.DisplayPrompt(); //prompt for string

                input = Console.ReadLine(); //get string
                NoSpaces(input); //delete excess spaces.

                if (input.Equals("q")) //if input equals "q"
                {
                    break;            //break the loop.
                }

                count = CountWords(input); //count words, assign to count.
                avgLetters = GetAvgChar(input,count); //calc average of letters per word.

                StdMsg.DisplayWordCount(count); //Display count
                StdMsg.DisplayAvgLetters(avgLetters); //Display average.
                Console.ReadLine();
            } while (true);

        }

        public static int CountWords(String input) //method accepts string as arg, returns number of words it contains
        {
            int numWords = 0; //counter starts at zero.
            if (input.Length == 0) //if the length of the string is zero
            {
                return numWords; //return zero.
            }

            String[] words = input.Split(null); //tokenize

            foreach (String word in words)
            {
                ++numWords;//Count each word.
            }
            return numWords;
        }

        public static double GetAvgChar(String input, int numWords)
        {
            double numChars = 0.0; //number of char

            String[] words = input.Split(null); //tokenize string.
            foreach (String word in words)
            {
                foreach(char ch in word)
                {
                    ++numChars; //count characters
                }
            }

            double avg = numChars / numWords; //calc average
            return avg;
        }

        public static void NoSpaces(String words) //Pass string as ref
        {
            while(words.Contains("  ")) //while the string contains double spaces
            {
                words = words.Replace("  ", " "); //replace double spaces with one space.
            }
        }
    }
    
}
