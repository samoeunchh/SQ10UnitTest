using System;
using SQ10UnitTest.Service;

namespace SQ10UnitTest.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var math = new MathFunc();
            int result = math.Factorial(3);
            System.Console.WriteLine("Result {0}",result);

        }
    }
}
