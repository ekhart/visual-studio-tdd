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
            float expected = (20000*(age - 20))*0.5f;
            var salary = new Salary("John", age);

            // act
            float actual = salary.GetSalary();

            // assert 
            Assert.AreEqual(expected, actual, $"Excpected {expected} not equals actual {actual}");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetSalary_WhenAgeLessThanTwenty_ShouldThrowException()
        {
            // arrange
            int age = 15;
            var salary = new Salary("John", age);

            // act
            var actual = salary.GetSalary();

            // assert
        }

        [TestMethod]
        public void GetSalary_WhenGreaterThanEightyFive_ShouldThrowException()
        {
            // arrange
            var salary = new Salary("John", 90);

            // act
            try
            {
                float actual = salary.GetSalary();
            }
            catch (ArgumentOutOfRangeException e)
            {
                // assert
                StringAssert.Contains(e.Message, Salary.ARGUMENTGREATERTHAN85);
                return;
            }

            Assert.Fail("No exception was thrown");
        }

        //- Assert.AreEquals: This fails when two values differ
        //- Assert.AreSame: This fails when two objects point to different locations
        //- Assert.Fail: This fails irrespective of any logic
        //- Assert.IsTrue/Assert.IsFalse: This determines the failure based on a true or false condition
        //- Assert.IsNull/Assert.IsNotNull: This fails when an object points to null
        //Similar to Assert, there are a number of other classes that are used to test values, 
        //such as StringAssert and CollectionAssert, which work specially on a set of types.
    }
}
