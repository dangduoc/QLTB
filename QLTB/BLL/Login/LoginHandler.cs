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
    public class LoginHandler
    {
        public UserModel CheckLogin(string username,string password, out string message)
        {
            try
            {
                using (var unitOfWork= new UnitOfWork())
                {
                    var entity=unitOfWork.GetRepository<HT_User>().GetById(username);
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
    }
}
