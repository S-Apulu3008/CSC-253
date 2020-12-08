using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail
{
    public class StdMsg
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("retail price calculator");
            Console.Write("-----------------------" +
                          "\n1. adjust markup percentage" +
                          "\n2. calculate retail" +
                          "\n3. exit" +
                          "\n>");
        }

        public static void ShowCurrentMarkup(double markUp)
        {
            Console.Write($"current markup: [{markUp}%]" +
               "\nnew markup: ");
        }

        public static void ShowUpdatedMarkup(double markUp)
        {
            Console.Write($"markup updated: [{markUp}%]");
            Console.ReadLine();
        }

        public static void GetWholeSalePrompt()
        {
            Console.Write("enter wholesale cost: ");
        }

        public static void ShowRetailPrice(double retail)
        {
            Console.Write($"retail cost: ${retail}");
            Console.ReadLine();
        }

    }
}
