using Microsoft.VisualStudio.TestTools.UnitTesting;
using Retail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*
* S A
* CSC=253
* 10.18.2020
* Retail Price Calc Unit Test
*/

namespace Retail.Tests
{
    [TestClass()]
    public class PriceCalcTests
    {
        [TestMethod()]
        public void CalcRetailTest()
        {
            //arrange
            double expected = 1.07;

            //act
            double actual = PriceCalc.CalcRetail(1, 7);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}