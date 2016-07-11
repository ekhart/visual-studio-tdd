using System;

namespace MSFakesSample.Tests
{
    internal class StubLogger : ILogger
    {
        public bool IsLoggerEnabled { get; set; }
        public StubObserver InstanceObserver { get; set; }

        public void Log(string message)
        {
            throw new NotImplementedException();
        }
    }
}