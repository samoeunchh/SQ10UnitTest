using System;

namespace SQ10UnitTest.Service
{
    public class MathFunc
    {
        // n!= n x (n-1)!
        public int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public int Sum(int v1, int v2) => v1 + v2;
        public int Sum(int v1, int v2, int v3) => v1 + v2 + v3;
    }
}
