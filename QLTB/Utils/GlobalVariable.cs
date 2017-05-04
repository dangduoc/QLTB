using QLTB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Utils
{
    public static class GlobalVariable
    {
        private static UserModel WorkingUser;
        public static void SetUser(UserModel user)
        {
            WorkingUser = user;
        }
        public static UserModel GetUser()
        {
            return WorkingUser;
        }
    }
}
