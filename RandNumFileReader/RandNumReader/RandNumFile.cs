using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * S A
 * CSC-253
 * 10.11.2020
 * Random Number File Reader
 */

namespace RandNumReader
{
    public class RandNumFile
    {
        public static void Reader(StreamReader reader, string fileName, List<int> numList)
        {
            while (!reader.EndOfStream) //while not at the end of file
            {
                int.TryParse(reader.ReadLine(), out int num); //try to parse line to an int.
                numList.Add(num); //add int to list
            }
        }
    }
}
