using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingSample.Tests
{
    [TestClass]
    public class SalaryTests
    {
        [TestMethod]
        public void GetSalary_ValidValues()
        {
            // arrange
            int age = 50;
            float expected = (20000*(age - 20))*1;
            var salary = new Salary("John", age);

            // act
            float actual = salary.GetSalary();

            // assert 
            Assert.AreEqual(expected, actual, $"Excpected {expected} not equals actual {actual}");
        }
    }
}
