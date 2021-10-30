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
        [TestMethod]
        public void User_LoginEmptyeUserPwd()
        {
            var user = new UserService();
            string result = user.Login(null, "123");
            Assert.AreEqual("User or password is required", result);
        }
        [TestMethod]
        public void User_LoginInvalidUserPwd()
        {
            var user = new UserService();
            string result = user.Login("abc", "123");
            Assert.AreEqual("Invalid user name or password", result);
        }
    }
}
