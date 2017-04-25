using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class BaseGiaoVienModel
    {
        public string GiaoVienId { get; set; }
        public string HoVaDem { get; set; }
        public string Ten { get; set; }
        public string TenDayDu { get; set; }
        public int GioiTinhId { get; set; }
       
        public Nullable<int> MonHocId { get; set; }
    }
    public class GiaoVienModel:BaseGiaoVienModel
    {
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public Nullable<int> DanTocId { get; set; }
        public string DienThoaiDD { get; set; }
        public string DienThoaiCQ { get; set; }
        public string EmailCN { get; set; }
        public string EmailCQ { get; set; }
        public Nullable<int> ViTriId { get; set; }
        
        public Nullable<int> ChucVuId { get; set; }
        public string ChucVuKiemNhiem { get; set; }
        public int PhongBanId { get; set; }
        public int LoaiHopDongId { get; set; }
        public System.DateTime NgayVaoNganh { get; set; }
        public Nullable<int> TrinhDoId { get; set; }
        public Nullable<int> TrinhDoChuanId { get; set; }
        public Nullable<int> QuanLyNhaNuocId { get; set; }
        public Nullable<int> QuanLyGiaoDucId { get; set; }
        public Nullable<bool> IsThamGiaBoiDuong { get; set; }
        public Nullable<bool> IsLaDangVien { get; set; }
        public Nullable<int> LyLuanChinhTriId { get; set; }
        public Nullable<System.DateTime> NgayVaoDang { get; set; }
    }
    public class GiaoVienGirdDisplayModel
    {
        public string GiaoVienId { get; set; }
        public string TenDayDu { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string PhongBan { get; set; }
        public string ViTriViecLam { get; set; }
        public string ChucVu { get; set; }
        public string DayMon { get; set; }
        public string TrinhDoChuyenMon { get; set; }
        public string LoaiHopDong { get; set; }
    }
    public class GiaoVienCreateModel
    {
        public string HoVaDem { get; set; }
        public string Ten { get; set; }
        public string TenDayDu { get; set; }
        public int GioiTinhId { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public Nullable<int> DanTocId { get; set; }
        public string DienThoaiDD { get; set; }
        public string DienThoaiCQ { get; set; }
        public string EmailCN { get; set; }
        public string EmailCQ { get; set; }
        public Nullable<int> ViTriId { get; set; }
        public Nullable<int> MonHocId { get; set; }
        public Nullable<int> ChucVuId { get; set; }
        public string ChucVuKiemNhiem { get; set; }
        public int PhongBanId { get; set; }
        public int LoaiHopDongId { get; set; }
        public System.DateTime NgayVaoNganh { get; set; }
        public Nullable<int> TrinhDoId { get; set; }
        public Nullable<int> TrinhDoChuanId { get; set; }
        public Nullable<int> QuanLyNhaNuocId { get; set; }
        public Nullable<int> QuanLyGiaoDucId { get; set; }
        public Nullable<bool> IsThamGiaBoiDuong { get; set; }
        public Nullable<bool> IsLaDangVien { get; set; }
        public Nullable<int> LyLuanChinhTriId { get; set; }
        public Nullable<System.DateTime> NgayVaoDang { get; set; }
    }
    public class GiaoVienUpdateModel
    {
        public string HoVaDem { get; set; }
        public string Ten { get; set; }
        public string TenDayDu { get; set; }
        public int GioiTinhId { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public Nullable<int> DanTocId { get; set; }
        public string DienThoaiDD { get; set; }
        public string DienThoaiCQ { get; set; }
        public string EmailCN { get; set; }
        public string EmailCQ { get; set; }
        public Nullable<int> ViTriId { get; set; }
        public Nullable<int> MonHocId { get; set; }
        public Nullable<int> ChucVuId { get; set; }
        public string ChucVuKiemNhiem { get; set; }
        public int PhongBanId { get; set; }
        public int LoaiHopDongId { get; set; }
        public System.DateTime NgayVaoNganh { get; set; }
        public Nullable<int> TrinhDoId { get; set; }
        public Nullable<int> TrinhDoChuanId { get; set; }
        public Nullable<int> QuanLyNhaNuocId { get; set; }
        public Nullable<int> QuanLyGiaoDucId { get; set; }
        public Nullable<bool> IsThamGiaBoiDuong { get; set; }
        public Nullable<bool> IsLaDangVien { get; set; }
        public Nullable<int> LyLuanChinhTriId { get; set; }
        public Nullable<System.DateTime> NgayVaoDang { get; set; }
    }
}
