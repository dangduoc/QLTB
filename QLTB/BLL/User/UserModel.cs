using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string UserRoleId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
    }
    public class UserRole
    {
        public string UserRoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
