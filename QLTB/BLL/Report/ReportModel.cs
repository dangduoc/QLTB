using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Report.Model
{
    public class GhiTangReportModel
    {
       public string NgayGhiTang { get; set; }
        public string PhieuGhiTangId { get; set; }
        public string ThietBiId { get; set; }
        public string TenTB { get; set; }
        public string SoHieu { get; set; }
        public string NuocSX { get; set; }
        public string PhongBM { get; set; }
        public string DVT { get; set; }
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien { get; set; }
        public string NguonKP { get; set; }
        public string GhiChu { get; set; }
    }
    public class ThietBiReportModel
    {
        public string ThietBiId { get; set; }
        public string SoHieu { get; set; }
        public string Ten { get; set; }
        public string PhongBM { get; set; }
        public string MonHoc { get; set; }
        public string DonViTinh { get; set; }
        public string QuyCachSD { get; set; }
        public string NamDuaVaoSD { get; set; }
        public string NamTheoDoi { get; set; }
        public int SoLuong { get; set; }
        public int SoLuongMuon { get; set; }
        public int SoLuongCon { get; set; }
        public int SoLuongMat { get; set; }
        public int SoLuongHong { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien { get; set; }
        public string GhiChu { get; set; }
    }
    public class ThietBiMuaReportModel
    {
        public string MaThietBi { get; set; }
        public string Ten { get; set; }
        public string LoaiTB { get; set; }
        public string SoLuongDangCo { get; set; }
        public string SoLuongDeNghi { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien { get; set; }
        public bool isTuMua { get; set; }
    }
    public class HCHetHanReportModel
    {
        public string Ten { get; set; }
        public string MaTB { get; set; }
        public string SoHieu { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public string NoiSX { get; set; }
        public string NgaySX { get; set; }
        public string HanSD { get; set; }
        public string GhiChu { get; set; }
    }
}
