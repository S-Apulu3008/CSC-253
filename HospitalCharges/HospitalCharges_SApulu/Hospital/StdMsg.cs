using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * S. Apulu
 * CSC 253
 * 9.1.2020
 * Hospital Charges
 */

namespace Hospital
{
    public class StdMsg
    {
        public static void Header()
        {
            Console.WriteLine("Hospital Charges\n" +
                     "----------------");
        }

        public static void NumberOfDaysPrompt()
        {
            Console.Write("Enter number of days patient has stayed: ");
        }

        public static void MedCostPrompt()
        {
            Console.Write("Enter medication costs: ");
        }

        public static void SurgCostPrompt()
        {
            Console.Write("Enter surgical costs: ");
        }

        public static void LabFeePrompt()
        {
            Console.Write("Enter lab fees: ");
        }

        public static void RehabCostPrompt()
        {
            Console.Write("Enter physical rehab costs: ");
        }

        public static void ShowSummaryTotal(int days, double chargePerday, double stayCost, double miscCost, double totalCost)
        {
            Console.WriteLine($"Stay cost: (${chargePerday}) x days stayed ({days}) = ${stayCost}");
            Console.WriteLine($"Misc cost: ${miscCost}");
            Console.WriteLine($"Total cost: ${totalCost}");
        }
    }
}
