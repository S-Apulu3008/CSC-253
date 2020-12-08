using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IgPayAtinLay;
/*
 * S A
 * CSC-253
 * 9.16.2020
 * Plaintext to Pig Latin * 
 */
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            String input, pigLatin;

            do
            {
                //top of loop body.
                StdMsg.Clear();
                StdMsg.DisplayHeader(); //DisplayHeader
                StdMsg.AskForStringPrompt(); //ask for string
                input = Console.ReadLine();  //get string from user
                if(input.Equals("q")) //if input equals q
                {
                    break; //then break loop. exit.
                }
                else if(input.Equals("")) //else if input equals "" empty string
                {
                    StdMsg.Clear(); //clear screen
                    StdMsg.TryAgainPrompt();//prompt user to try again
                    StdMsg.Stop();
                    continue; //continue from top of loop body.
                }
                pigLatin = ProcessTxt.ToPigLatin(input); //process string to pig latin and assign to pigLatin
                StdMsg.DisplayPigLatin(pigLatin); //display pig latin
                StdMsg.ContinuePrompt(); //display continue prompt
                StdMsg.Stop();
            }while(true);
        }
    }
}
