using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Model;
using QLTB.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Handler
{
    public class UserHandler
    {
        public List<string> getTreeViewNode(int roleId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var list = unitOfWork.GetRepository<QH_User_Permission>().GetAll().Where(p => p.UserRoleId == roleId).Select(p => p.PermissionKey).ToList();
                    if (list != null)
                    {
                        return list;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool AddPermission(UserPermission permission)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var entity = new HT_Permission
                    {
                        PermissionId = permission.PermissionId,
                        Name = permission.Name,
                        PermissionKey = permission.PermissionKey,
                        ParentId = permission.PermissionId,
                    };
                    unitOfWork.GetRepository<HT_Permission>().Add(entity);
                    if (unitOfWork.Save()>=1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }
        public List<UserTreeViewModel> GetUsers()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    return unitOfWork.GetRepository<HT_User>().GetAll()
                        .Join(unitOfWork.GetRepository<HT_UserRole>().GetAll(),
                        u=>u.UserRoleId,
                        r=>r.UserRoleId,
                        (u,r)=> new UserTreeViewModel
                        {
                            UserId = u.UserId,
                            Email = u.Email,
                            PassWord = u.PassWord,
                            UserName = u.UserName,
                            UserRoleId = u.UserRoleId,
                            Name = u.Name,
                            Note = u.Note,
                            PhoneNumber = u.PhoneNumber,
                            UserRoleName=r.Name
                        }).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public UserRole GetRoleById(int Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var entity = unitOfWork.GetRepository<HT_UserRole>().GetById(Id);
                    if (entity != null)
                    {
                        return MyConvert.ConvertSameData<UserRole>(entity);
                    } 
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public UserModel GetUserById(int Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var entity = unitOfWork.GetRepository<HT_User>().GetById(Id);
                    if (entity != null)
                    {
                        return MyConvert.ConvertSameData<UserModel>(entity);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<QHUserPermission> GetPermissionsOfRole(int RoleId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    return unitOfWork.GetRepository<QH_User_Permission>().GetAll().Where(p => p.UserRoleId == RoleId)
                        .Select(p => new QHUserPermission {
                            UserRoleId=p.UserRoleId,
                            PermissionId=p.PermissionId,
                            PermissionKey=p.PermissionKey,
                            isAdd=p.isAdd,
                            isDelete=p.isDelete,
                            isUpdate=p.isUpdate,
                            isView=p.isView
                        }).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
