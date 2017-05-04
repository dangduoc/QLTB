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
    }
    public class ThietBiModel: BaseThietBiModel
    {
        public string QuyCachSD { get; set; }
        public int PhongHocId { get; set; }
        public int NguonKinhPhiId { get; set; }
        public short NamDuaVaoSD { get; set; }
        public DateTime NgayDuaVaoSD { get; set; }
        public short NamTheoDoi { get; set; }
        public int DonViTinhId { get; set; }
        public short SoLuong { get; set; }
        public short SoLuongMat { get; set; }
        public short SoLuongHong { get; set; }
        public double? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public string NuocSanXuat { get; set; }
        public int MucDichSDId { get; set; }
        public bool IsThietBiTuLam { get; set; }
        public DateTime? NgaySanXuat { get; set; }
        public int TrangThai { get; set; }
        public DateTime? HanSD { get; set; }
        public string GhiChu { get; set; }
        public string CreateByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public string UpdatedByUserId { get; set; }
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
        public string SoLuongMat { get; set; }
        public string SoLuongHong { get; set; }
    }
}
