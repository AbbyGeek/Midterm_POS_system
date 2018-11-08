using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using POS_Terminal;

namespace DumbTestThing1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GrandTotalTest()
        {
            //arrange
            double subtotal = 60;
            double tax = 3.6;

            //act
            double grandTotal = GrandTotal.FinalTotal(subtotal, tax);

            //assert
            Assert.AreEqual(grandTotal, 63.6);
        }
        [TestMethod]
        public void DigitTest()
        {
            //arrange
            int num = 1234567890;

            //act

            //assert
            Assert.IsTrue(MiscMethods.IsOnlyDigits(num.ToString()));
        }
    }
}
