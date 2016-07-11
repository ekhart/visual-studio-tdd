namespace MSFakesSample.Tests
{
    internal class StubObserver
    {
        public StubObserver()
        {
        }

        public string[] GetCalls()
        {
            return new[] {"adin", "dwa"};
        }
    }
}