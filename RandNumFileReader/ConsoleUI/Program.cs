using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RandNumReader;
/*
 * S A
 * CSC-253
 * 10.11.2020
 * Random Number File Reader
 */


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader; //reader object
            List<int> numbers = new List<int> { }; //list of ints
            StdMsg.GetFileNamePrompt(); //ask for file name
            string fileName = Console.ReadLine(); //get file name
            try //try to..
            {
                reader = File.OpenText($@"..\..\{fileName}.txt"); //open the file.
                RandNumFile.Reader(reader, fileName, numbers); //read numbers from file. add to list.
                reader.Close(); //close the file.
                StdMsg.ShowFileName(fileName); //show file name.
                StdMsg.ShowLineCount(numbers); //show the line count.
                StdMsg.ShowRandomNumSum(numbers); //show the sum of all numbers read from file.
                StdMsg.Stop();
            }
            catch
            {
                StdMsg.FileNotFound(fileName);
                StdMsg.Stop();
            }
        }
    }
}
