using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQ10UnitTest.Service;

namespace SQ10UnitTest.Testing
{
    [TestClass]
    public class MathFuncTest
    {
        [TestMethod]
        public void Fact_LessOrEqualOne_One()
        {
            var math = new MathFunc();
            int result = math.Factorial(0);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Fact_BiggerThanOne_N()
        {
            var math = new MathFunc();
            int result = math.Factorial(4);
            Assert.AreEqual(24, result);
        }
    }
}
