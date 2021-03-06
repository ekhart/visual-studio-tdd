﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingSample.Tests
{
    [TestClass]
    public class SalaryPrivateTests
    {
        [TestMethod]
        public void TestPrivateMembers()
        {
            var name = "Abhishek";
            var age = 30;
            var salary = new Salary(name, age);

            var privateSalary = new PrivateObject(salary);

            Assert.AreEqual(age, Convert.ToInt32(privateSalary.GetField("age")));
            Assert.AreEqual(name, privateSalary.GetFieldOrProperty("name") as string);
        }

        [TestMethod]
        public void GetName_StaticMethodTest()
        {
            var name = "Abhishek";
            var age = 30;
            var salary = new Salary(name, age);

            var privateType = new PrivateType(typeof(Salary));

            Assert.AreEqual(name, privateType.InvokeStatic("GetName", salary) as string);
        }
    }
}
