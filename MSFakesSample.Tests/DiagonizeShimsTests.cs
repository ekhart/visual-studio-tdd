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

        [TestMethod]
        //[ExpectedException(typeof(ShimNotImplementedException))]
        public void DeleteDirectory_BehaveNotImplemented()
        {
            //using (ShimsContext.Create())
            //{
            //    ShimDirectory.BehaveAsNotImplemented();
            //    var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //    DiagonizeShims.DeleteTemporaryData(appData);
            //}
        }

        [TestMethod]
        public void GetEventName_Test()
        {
            //var logger = new StubLogger {IsLoggerEnabled = () => true};
            //var diagonizeStubs = new DiagonizeStubs();

            //var result = diagonizeStubs.GetEventName(logger);

            //Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        [TestMethod]
        public void GetEventName_Test_Fakes()
        {
            //var stubLogger = new StubLogger { IsLoggerEnabled = () => true };
            //var diagonizeStubs = new DiagonizeStubs();
            //var observer = new StubObserver();
            //stubLogger.InstanceObserver = observer;

            //diagonizeStubs.GetEventName(stubLogger);
            //var calls = observer.GetCalls();

            //Assert.IsNotNull(calls);
            //Assert.AreEqual(2, calls.Length);
        }
    }
}
