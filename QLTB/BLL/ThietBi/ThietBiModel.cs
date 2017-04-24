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
        public string QuyCach { get; set; }
        public int PhongHocId { get; set; }
        public int NguonKinhPhiId { get; set; }
        public int NamDuaVaoSD { get; set; }
        public int NamTheoDoi { get; set; }
        public int DonViTinhId { get; set; }
        public int SoLuong { get; set; }
        public int SoLuongMat { get; set; }
        public int SoLuongHong { get; set; }
        public int DonGia { get; set; }
        public int ThanhTien { get; set; }
        public string NuocSX { get; set; }
        public int MucDichSDId { get; set; }
        public bool IsThietBiTuLam { get; set; }
        public DateTime NgaySanXuat { get; set; }
        
        public DateTime HanSD { get; set; }
        public int TrangThaiId { get; set; }
        public string GhiChu { get; set; }
    }
    public class ThietBiGridDisplayModel
    {
        public string ThietBiId { get; set; }
        public string SoHieu { get; set; }
        public string Ten { get; set; }
        public string KhoPhong { get; set; }
        public string BoMon { get; set; }
        public string KhoiLop { get; set; }
        public string SoLuong { get; set; }
        public string SoLuongMat { get; set; }
        public string SoLuongHong { get; set; }
        public string TrangThai { get; set; }
    }
}
