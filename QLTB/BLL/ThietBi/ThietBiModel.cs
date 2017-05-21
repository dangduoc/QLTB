using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class BaseThietBiModel
    {
        public string ThietBiId { get; set; }
        public string SoHieu { get; set; }
        public string Ten { get; set; }
        public int PhongHocId { get; set; }
        public Nullable<int> MonHocId { get; set; }
        public int DonViTinhId { get; set; }
    }
    public class ThietBiModel : BaseThietBiModel
    {
        public string QuyCachSD { get; set; }
        public int NguonKinhPhiId { get; set; }
        public int NamDuaVaoSD { get; set; }
        public System.DateTime NgayDuaVaoSD { get; set; }
        public int NamTheoDoi { get; set; }
        public int SoLuong { get; set; }
        public int SoLuongCon { get; set; }
        public int SoLuongMat { get; set; }
        public int SoLuongHong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
        public string NuocSanXuat { get; set; }
        public int MucDichSDId { get; set; }
        public bool IsThietBiTuLam { get; set; }
        public Nullable<System.DateTime> NgaySanXuat { get; set; }
        public Nullable<System.DateTime> HanSD { get; set; }
        public string GhiChu { get; set; }
        public int TrangThai { get; set; }
        public Nullable<int> CreateByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    }
    public class ThietBiGridDisplayModel
    {
        public string SoHieu { get; set; }
        public string ThietBiId { get; set; }
        public string Ten { get; set; }
        public string KhoPhong { get; set; }
        public string MonHoc { get; set; }
        public string SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public string SoLuongMat { get; set; }
        public string SoLuongHong { get; set; }
        public string TrangThai { get; set; }
    }
    public class BaseThietBiGridDisplayModel{
        public string ThietBiId { get; set; }
        public string SoHieu { get; set; }
        public string Ten { get; set; }
        public string PhongHoc { get; set; }
        public string DonViTinh { get; set; }
    }
    public class BasePhieuThietBiModel
    {
        public string SoPhieu { get; set; }
        public DateTime NgayLap { get; set; }
        public string NoiDung { get; set; }
    }
    public class BasePhieuTBGridDisplayModel
    {
        public string SoPhieu { get; set; }
        public string NgayLap { get; set; }
        public string NoiDung { get; set; }
    }
    public class BaseThietBiHongDialogModel
    {
        public string SoHieu { get; set; }
        public string MaThietBi { get; set; }
        public string Ten { get; set; }
        public string Loai { get; set; }
        public string TinhTrang { get; set; }
        public string SoPhieuBaoHong { get; set; }
    }
}
