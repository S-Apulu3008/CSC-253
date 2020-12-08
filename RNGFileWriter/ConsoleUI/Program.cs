using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RandomNumGen;

/* 
 * SA
 * CSC-253
 * 10.9.2020
 * Random Number File Writer
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter outFile = File.CreateText(@"..\..\random_nums.txt"); //create a file/open existing file for write called random_nums.txt
            int num = GenRandNums.GetInt(); //get num of random ints to write to file from user.
            GenRandNums.ToFile(outFile, num); //writes num number of random numbers (1-100) to file.
            GenRandNums.FileClose(outFile); //close the file.
            StdMsg.DonePrompt(); //done
            StdMsg.Stop();
        }
    }
}
