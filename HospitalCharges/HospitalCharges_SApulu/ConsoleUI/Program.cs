using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital;//using Hospital class library
/*
 * S. Apulu
 * CSC 253
 * 9.1.2020
 * Hospital Charges
 */


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int days; // # of days stayed.

            double medCost, //medication costs
                   surgCost, //surgical costs
                   rehabCost, //rehab costs
                   labFees, //lab fees
                   stayCost, //stay costs
                   chargePerday = 350.00, // $350 per day
                   miscCost, 
                   totalCost; //total costs

            StdMsg.Header();

            StdMsg.NumberOfDaysPrompt();//days Prompt
            days = Calc.GetInt();//Get number of days

            StdMsg.MedCostPrompt(); //meds prompt
            medCost = Calc.GetDouble(); //get medication cost

            StdMsg.SurgCostPrompt(); //surgical prompt
            surgCost = Calc.GetDouble(); //get surgery cost

            StdMsg.LabFeePrompt(); //lab prompt
            labFees = Calc.GetDouble(); //get lab fee

            StdMsg.RehabCostPrompt(); //rehab prompt
            rehabCost = Calc.GetDouble();//get rehab cost

            Console.WriteLine();
                        
            stayCost = Calc.CalcStayCharges(days, chargePerday); //calculate stay costs
            miscCost = Calc.CalcMiscCharges(medCost, surgCost, labFees, rehabCost); //calc misc cost
            totalCost = Calc.CalcTotalCharges(miscCost, stayCost); //Total charges.

            Hospital.StdMsg.ShowSummaryTotal(days, chargePerday, stayCost, miscCost, totalCost);//Cost summary prompt
            Console.WriteLine("\nDone.");
            Console.ReadLine();

        }//end main
    }
}
