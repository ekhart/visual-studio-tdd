using System;

namespace MSFakesSample
{
    public interface ILogger
    {
        bool IsLoggerEnabled { get; }
        void Log(string message);
    }
}