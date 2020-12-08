using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]
        public void CalcStayChargesTest()
        {
            //arrange
            double expected = 700;

            //act
            double actual = Calc.CalcStayCharges(2, 350);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcMiscChargesTest()
        {
            //arrange
            double expected = 40;

            //act
            double actual = Calc.CalcMiscCharges(10, 10, 10, 10);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcTotalChargesTest()
        {
            //arrange
            double expected = 740;

            //act
            double actual = Calc.CalcTotalCharges(40, 700);
            Assert.AreEqual(expected, actual);
        }
    }
}