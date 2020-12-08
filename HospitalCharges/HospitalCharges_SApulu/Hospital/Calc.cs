using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Calc
    {
        public static double CalcStayCharges(int days, double chargePerDay)// calculate total stay charges
        {
            return days * chargePerDay; //Number of days times cost.
        }

        public static double CalcMiscCharges(double medCost, double surgCost, double labFees, double rehabCost)//calculate misc charges
        {
            return medCost + surgCost + labFees + rehabCost;
        }

        public static double CalcTotalCharges(double miscCost, double stayCost)//calculate total charges
        {
            return miscCost + stayCost;
        }

        public static double GetDouble()//get a proper double.
        {
            double cost;
            do
            {
                if (Double.TryParse(Console.ReadLine(), out cost))
                {
                    return cost;
                }
                else
                {
                    Console.WriteLine("Try again.\n>");
                    continue;
                }
            } while (true);
        }

        public static int GetInt()//get a proper int.
        {
            int number;
            do
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Try again.\n>");
                    continue;
                }
            } while (true);
        }
    }
}
