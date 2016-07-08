using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDSample.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void BasicDivideTest()
        {
            var calculator = new Calculator();
            var expected = 4d;

            var actual = calculator.Divide(20d, 5d);

            Assert.AreEqual(expected, actual);
        }
    }
}
