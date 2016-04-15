using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DojoLeapYear;

namespace LeapYearTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsLeapYear_NotDivisileBy4_ReturnFalse()
        {
            bool expected = false;
            bool result = Leapyear.IsLeapYear(5);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsLeapYear_NotDivisileBy100_ReturnFalse()
        {
            bool expected = false;
            bool result = Leapyear.IsLeapYear(1900);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsLeapYear_NotDivisileBy400_ReturnTrue()
        {
            bool expected = true;
            bool result = Leapyear.IsLeapYear(2000);
            Assert.AreEqual(expected, result);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void IsLeapYear_LessThen0_ThrowsArgumentExcception()
        {
            bool expected = true;
            bool result = Leapyear.IsLeapYear(-3);
            Assert.AreEqual(expected, result);
        }


    }
}
