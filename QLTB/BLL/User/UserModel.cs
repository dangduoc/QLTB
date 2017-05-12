using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int UserRoleId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string Name { get; set; }
    }
    public class UserTreeViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int UserRoleId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string Name { get; set; }
        public string UserRoleName { get; set; }

    }
    public class UserRole
    {
        public int UserRoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class UserPermission
    {
        public int PermissionId { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string Description { get; set; }
        public string PermissionKey { get; set; }
      
    }
    public class ObjectPermission
    {
        public int Id { get; set; }
        public int? parentId { get; set; }
        public bool isAdd { get; set; }
        public bool isUpdate { get; set; }
        public bool isView { get; set; }
        public bool isDelete { get; set; }
    }
    public class PermissionNode
    {
        public string NodeName { get; set; }
        public bool Checked { get; set; }
        public bool isAdd { get; set; }
        public bool isUpdate { get; set; }
        public bool isView { get; set; }
        public bool isDelete { get; set; }
    }
    public class QHUserPermission
    {
        public int UserRoleId { get; set; }
        public int PermissionId { get; set; }
        public string PermissionKey { get; set; }
        public Nullable<bool> isView { get; set; }
        public Nullable<bool> isAdd { get; set; }
        public Nullable<bool> isUpdate { get; set; }
        public Nullable<bool> isDelete { get; set; }
    }
}
