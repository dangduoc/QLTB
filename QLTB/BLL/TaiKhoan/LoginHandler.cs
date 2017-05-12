using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Model;
using QLTB.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB.Handler
{
    public class LoginHandler
    {
        public UserModel CheckLogin(string username,string password, out string message)
        {
            try
            {
                using (var unitOfWork= new UnitOfWork())
                {
                    var entity = unitOfWork.GetRepository<HT_User>().GetById(1);
                    if (entity != null) {
                        if (entity.PassWord.Equals(password))
                        {
                            message = "";
                            return MyConvert.ConvertSameData<UserModel>(entity);
                        }
                        else
                        {
                            message = "Mật khẩu không đúng";
                            return null;
                        }
                    }
                    else
                    {
                        message = "Tài khoản không tồn tại";
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Có lỗi xảy ra, vui lòng thử lại lúc khác";
                return null;
            }
        }

        //public void loadPermissions(TreeView menu,int roleId)
        //{
        //    List<string> Keys = new List<string>();
        //    foreach(TreeNode item in menu.Nodes)
        //    {
        //        string permissionKey = item.Name;
        //        if (!Keys.Contains(permissionKey)){
        //            item.Remove();
        //        }
        //    }
        //}
        public void loadPermissions(TreeView menu)
        {
            int permissionKey = 0;
            foreach(TreeNode item in menu.Nodes)
            {
                
            }
        }
    }
}
