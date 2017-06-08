using QLTB.Handler;
using QLTB.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB.Utils
{
    public static class GlobalVariable
    {
        private static UserModel WorkingUser;
        private static DanhSachModel DanhSach;
        private static ThongTinHeThong HeThong;
        public static void SetUser(UserModel user)
        {
            WorkingUser = user;
        }
        public static UserModel GetUser()
        {
            WorkingUser = new UserModel
            {
                UserId = 1,
                UserName = "admin",
                PassWord = "123456",
                Email = "dangduoc@outlook.com",
                UserRoleId = 1,
                PhoneNumber = "01638004227",
                Name = "Đặng Minh Được",
                Note = ""
            };
            return WorkingUser;
        }
        public static void InitDanhSach()
        {
            DanhSach = new DanhSachModel();
            DanhSach.ViTriGiaoVien=DanhSach.ViTriGiaoVien.Where(p => p.CapHocId == HeThong.DonVi.CapTruongId).AsEnumerable();
            
        }
        public static DanhSachModel GetDS()
        {
            return DanhSach;
        }
        public static void SetHeThong()
        {
            HeThong = new ThongTinHeThong();
            HeThong.DonVi = new DbThongTinDVHandler().Get();
            HeThong.NamHoc = new DbThongTinNHHandler().GetNamHocActive();
            
        }
        public static ThongTinHeThong GetHeThong()
        {
            return HeThong;
        }


        public static string ImagePath()
        {
            string PATH = Path.GetDirectoryName(Application.ExecutablePath);
            return Path.Combine(PATH, "AnhDaiDien");
        }
    }
    public class ThongTinHeThong
    {
        public ThongTinDonViModel DonVi { get; set; }
        public ThongTinNamHocModel NamHoc { get; set; }
    }
}
