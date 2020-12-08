using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail
{
    public class PriceCalc
    {
        public static double CalcRetail(double wholeSaleCost, double markupPercent)
        {
            /*
                Divide the markupPercent by 100 to convert to decimal.
                Multiply markupPercent by the wholeSaleCost and then
                add that to the wholesale to get retail price.
            */
            return wholeSaleCost + (wholeSaleCost * (markupPercent / 100));
        }

    }
}
