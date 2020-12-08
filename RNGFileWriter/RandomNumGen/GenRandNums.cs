using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
* SA
* 
*/

namespace RandomNumGen
{
    public class GenRandNums
    {
        public static int GetInt() //Get an int
        {
            do //loop start
            {
                StdMsg.HowManyPrompt(); //Ask for how many random ints to produce
                if (int.TryParse(Console.ReadLine(), out int num)) //if input can be parsed to int
                {
                    return num; //then return int type. fin.
                }
                else //if input can't be parsed to int
                {
                    StdMsg.TryAgainPrompt(); //Try again prompt
                }
            } while (true); //go to loop start
        }

        public static void ToFile(StreamWriter writer, int num) //GenRandNums.ToFile
        {
            Random rnd = new Random(); //Random obj
            for (int i = 0; i < num; ++i) //for num times..
            {
                writer.WriteLine(rnd.Next(1, 101)); //write a random number between 1 and 100 to the next line in the file.
            }
        }

        public static void FileClose(StreamWriter writer)
        {
            writer.Close(); //close the file.
        }

        public static void ToConsole(int num) //GenRandNums.ToConsole
        {
            Random rnd = new Random(); //Random obj.
            for (int i = 0; i < num; ++i) //for num times..
            {
                StdMsg.ShowRandomInt(rnd); //Display a random number between 1 and 100 to the console.
            }
        }

    }
}
