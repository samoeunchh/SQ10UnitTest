using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQ10UnitTest.Service;

namespace SQ10UnitTest.Testing
{
    [TestClass]
    public class UserTesting
    {
        [TestMethod]
        public void User_LoginValideUserPwd()
        {
            var user = new UserService();
            string result = user.Login("Admin", "123");
            Assert.AreEqual("correct user and password", result);
        }
    }
}
