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

        [TestMethod]
        public void RangeDivideTest()
        {
            var calculator = new Calculator();

            for (var a = -100d; a < 100d; a++)
            {
                for (var b = -100d; b < 100d; b++)
                {
                    AssertRange(calculator, a, b);
                }
            }
        }

        private static void AssertRange(Calculator calculator, double a, double b)
        {
            var expected = a/b;
            var actual = calculator.Divide(a, b);

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(double.IsInfinity(actual));
        }
    }
}
