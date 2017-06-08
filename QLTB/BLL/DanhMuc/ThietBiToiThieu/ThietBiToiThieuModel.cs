using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class BaseThietBiToiThieuModel
    {
        public string ThietBiId { get; set; }
        public string Ten { get; set; }
        public int DonViTinhId { get; set; }
    }
    public class ThietBiToiThieuModel:BaseThietBiToiThieuModel
    {
        public string DungChoLopHienThi { get; set; }
        public int LoaiThietBiId { get; set; }
        public int MonHocId { get; set; }
        public string MoTa { get; set; }
        public short SoLuong { get; set; }
        public Nullable<int> DauMucId { get; set; }
        public bool IsThuocDMTT { get; set; }
        public bool IsDanhChoGV { get; set; }
        public bool IsDanhChoHS { get; set; }
        public string GhiChu { get; set; }
        public int TrangThai { get; set; }
    }
    public class ThietBiTTGridDisplayModel
    {
        
        public string ThietBiId { get; set; }
        public string Ten { get; set; }
        public string DungChoLop { get; set; }
        public string LoaiThietBi { get; set; }
        public string MonHoc { get; set; }
        public string DauMuc { get; set; }
        public string SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public string MoTa { get; set; }
    }
    public class ThietBiTTCreateModel
    {
        public string Ten { get; set; }
        public int DonViTinh { get; set; }
        public string DungChoLopHienThi { get; set; }
        public int LoaiThietBiId { get; set; }
        public int MonHocId { get; set; }
        public string MoTa { get; set; }
        public short SoLuong { get; set; }
        public Nullable<int> DauMucId { get; set; }
        public bool IsThuocDMTT { get; set; }
        public bool IsDanhChoGV { get; set; }
        public bool IsDanhChoHS { get; set; }
        public string GhiChu { get; set; }
    }
    public class ThietBiTTUpdateModel
    {
        public string Ten { get; set; }
        public int DonViTinh { get; set; }
        public string DungChoLopHienThi { get; set; }
        public int LoaiThietBiId { get; set; }
        public int MonHocId { get; set; }
        public string MoTa { get; set; }
        public short SoLuong { get; set; }
        public Nullable<int> DauMucId { get; set; }
        public bool IsThuocDMTT { get; set; }
        public bool IsDanhChoGV { get; set; }
        public bool IsDanhChoHS { get; set; }
        public string GhiChu { get; set; }
    }
}
