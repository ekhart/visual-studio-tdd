namespace TDDSample.Tests
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public double Divide(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }

            return a/b;
        }
    }
}