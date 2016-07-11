using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;

namespace MSFakesSample.Tests
{
    [TestClass]
    public class DiagonizeShimsTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DoomsDay_Test_Shims()
        {
            //using (ShimsContext.Create())
            //{
            //    ShimDateTime.NowGet = () => new DateTime(2012, 12, 21);
                DiagonizeShims.DoomsDay();
            //}
        }
    }
}
