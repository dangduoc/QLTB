//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTB.DAL.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThongTinDonVi
    {
        public string MaDonVi { get; set; }
        public string Ten { get; set; }
        public string DonViChuQuan { get; set; }
        public int KhoiTruongId { get; set; }
        public int CapTruongId { get; set; }
        public int HinhThucDaoTaoId { get; set; }
        public int LoaiHinhTruongId { get; set; }
        public int LoaiTruongChuyenBietId { get; set; }
        public int HangTruongId { get; set; }
        public int VungMienId { get; set; }
        public bool IsDatChuanQG { get; set; }
        public int TinhThanhId { get; set; }
        public int QuanHuyenId { get; set; }
        public int PhuongXaId { get; set; }
        public string DuongPhoSoNha { get; set; }
        public string DiaChiHienThi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string HieuTruong { get; set; }
        public string KeToan { get; set; }
        public string CanBoTb { get; set; }
        public string NguoiLapBieu { get; set; }
    
        public virtual DS_HangTruong DS_HangTruong { get; set; }
        public virtual DS_HinhThucDaoTao DS_HinhThucDaoTao { get; set; }
        public virtual DS_LoaiHinhTruong DS_LoaiHinhTruong { get; set; }
        public virtual DS_LoaiTruongChuyenBiet DS_LoaiTruongChuyenBiet { get; set; }
        public virtual DS_PhuongXa DS_PhuongXa { get; set; }
        public virtual DS_QuanHuyen DS_QuanHuyen { get; set; }
        public virtual DS_TinhThanh DS_TinhThanh { get; set; }
        public virtual DS_VungMien DS_VungMien { get; set; }
    }
}
