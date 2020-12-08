using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostFreqCharLib;
/*
 * S A
 * CSC-253
 * 
 * user enters a string and displays 
 * the character that appears most
 * frequently
 * 
 * 9.16.2020
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            char mostFreqChar;

            do
            {
                StdMsg.Clear();
                StdMsg.AskForStringPrompt(); //Ask for string
                ProcessText.MostFreqChar(Console.ReadLine(), out mostFreqChar); //Process user string and assign to mostFreqChar
                if (mostFreqChar == '*') //if mostFreqChar equals '*'
                {
                    break; //then break the loop. exit.
                }
                else if (mostFreqChar != ' ') //else if mostFreqChar does not equal ' ' blank space,..
                {
                    StdMsg.MostFreqCharPrompt(mostFreqChar); //..then display most frequent character in the string.
                }
                else //for all else..
                {
                    StdMsg.TryAgainPrompt(); //..display try again prompt.
                }
                StdMsg.End();
            } while (true);
        }
    }
}
