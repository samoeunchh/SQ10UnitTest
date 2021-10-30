using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ10UnitTest.Service
{
    public class UserService
    {
        public string Login(string userNam,string pwd)
        {
            if(string.IsNullOrEmpty(userNam) 
                || string.IsNullOrEmpty(pwd))
            {
                return "User or password is required";
            }
            else
            {
                if(userNam=="Admin" && pwd == "123")
                {
                    return "correct user and password";
                }
                else
                {
                    return "Invalid user name or password";
                }
            }
        }
    }
}
