using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * S A
 * CSC-253
 * 10.11.2020
 * Random Number File Reader
 */

namespace RandNumReader
{
    public class StdMsg
    {
        public static void GetFileNamePrompt()
        {
            Console.Write("Enter Random Number Filename: ");
        }


        public static void FileNotFound(string fileName)
        {
            Console.WriteLine("File not found." +
                           $"\nCouldn't find {fileName}.txt");
        }

        public static void ShowFileName(string fileName)
        {
            Console.WriteLine($"Filename: {fileName}.txt");
        }

        public static void ShowLineCount(List<int> numList)
        {
            Console.WriteLine($"Line Count: {numList.Count}");
        }

        public static void ShowRandomNumSum(List<int> numList)
        {
            Console.WriteLine($"Sum of all random numbers: {numList.Sum()}");
        }

        public static void Stop()
        {
            Console.ReadLine();
        }
    }
}
