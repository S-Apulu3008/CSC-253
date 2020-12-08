using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            StreamWriter writer = File.CreateText("Test.txt");
            int num;
            Console.WriteLine("How many random numbers do you want to write to the file?");
            int.TryParse(Console.ReadLine(), out int thisMany);

            for(int i = 0; i < thisMany; ++i)
            {
                num = rnd.Next(1, 101); //assigns a random number to num
                writer.WriteLine(num);
            }
                
            writer.Close();
            Console.ReadLine();
        }
    }
}
