using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Retail;

/*
*
* S A
* CSC=253
* 10.18.2020
* Retail Price Calc
*/


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool replay = true;
            double markUp = 0.0,    //start markup percent
                      wholeSale,         //wholesale price
                         retail;            //retail price

            do
            {
                Console.Clear();    //Clear Screen and Display Menu
                StdMsg.DisplayMenu();
                switch (Console.ReadLine())
                {
                    case "1":   //Adjust markup. Startup markup percent is 0%
                        StdMsg.ShowCurrentMarkup(markUp);
                        Double.TryParse(Console.ReadLine(), out markUp);
                        StdMsg.ShowUpdatedMarkup(markUp); //Display new markup
                        break;

                    case "2": //Calculate Retail.
                        StdMsg.GetWholeSalePrompt();
                        Double.TryParse(Console.ReadLine(), out wholeSale); //Get Retail
                        retail = PriceCalc.CalcRetail(wholeSale, markUp); //Calculate Retail
                        StdMsg.ShowRetailPrice(retail); //Display Retail
                        break;

                    case "3":
                        replay = false;
                        break;

                    default: //invalid case inputs will just loop back to menu.
                        break;
                } //end switch

            } while (replay == true); //end while

        } //end main
    }
}
