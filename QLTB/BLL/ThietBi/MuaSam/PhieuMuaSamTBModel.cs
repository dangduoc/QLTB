using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class PhieuMuaSamTBModel
    {
        public string PhieuDeNghiId { get; set; }
        public string Ten { get; set; }
        public Nullable<int> NamHocId { get; set; }
        public Nullable<int> TrangThaiId { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public List<ThietBiMuaGridDisplayModel> ThietBis { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        
    }
    public class DeNghiMuaGridDisplayModel
    {
        public string SoPhieu { get; set; }
        public string Ten { get; set; }
        public string NamHoc { get; set; }
        public string NgayLap { get; set; }
        public string TrangThai { get; set; }
        
    }
    public class ThietBiMuaGridDisplayModel
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
    public class ThietBiMuaSamModel
    {
        public string ThietBiId { get; set;}
        public int SoLuongDeNghi { get; set; }
        public int DonGia { get; set; }

    }
    public class ThietBiMuaDialogModel
    {
        public string ThietBiId{get;set;}
        public string Ten { get; set; }
        public int DonGia { get; set; }
        public string NuocSX { get; set; }
        public int LoaiTBId { get; set; }
    }
}
