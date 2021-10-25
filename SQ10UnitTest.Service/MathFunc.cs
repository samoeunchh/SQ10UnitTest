using System;

namespace SQ10UnitTest.Service
{
    public class MathFunc
    {
        // n!= 
        public int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1) -1;
            }
        }
    }
}
