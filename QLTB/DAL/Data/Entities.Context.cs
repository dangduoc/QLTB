﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DM_GiaoVien> DM_GiaoVien { get; set; }
        public virtual DbSet<DM_KhoiLop> DM_KhoiLop { get; set; }
        public virtual DbSet<DM_LopHoc> DM_LopHoc { get; set; }
        public virtual DbSet<DM_MonHoc> DM_MonHoc { get; set; }
        public virtual DbSet<DM_NguonKinhPhi> DM_NguonKinhPhi { get; set; }
        public virtual DbSet<DM_PhongHocBoMon> DM_PhongHocBoMon { get; set; }
        public virtual DbSet<DM_ThietBiToiThieu> DM_ThietBiToiThieu { get; set; }
        public virtual DbSet<DM_ToBoMon> DM_ToBoMon { get; set; }
        public virtual DbSet<DS_BaiGiang> DS_BaiGiang { get; set; }
        public virtual DbSet<DS_DanToc> DS_DanToc { get; set; }
        public virtual DbSet<DS_DonViTinh> DS_DonViTinh { get; set; }
        public virtual DbSet<DS_NguonNganSach> DS_NguonNganSach { get; set; }
        public virtual DbSet<DS_PhongBan> DS_PhongBan { get; set; }
        public virtual DbSet<DS_PhuongXa> DS_PhuongXa { get; set; }
        public virtual DbSet<DS_QuanHuyen> DS_QuanHuyen { get; set; }
        public virtual DbSet<DS_TinhThanh> DS_TinhThanh { get; set; }
        public virtual DbSet<HT_Permission> HT_Permission { get; set; }
        public virtual DbSet<HT_User> HT_User { get; set; }
        public virtual DbSet<HT_UserRole> HT_UserRole { get; set; }
        public virtual DbSet<QH_PhieuBaoHong_ThietBi> QH_PhieuBaoHong_ThietBi { get; set; }
        public virtual DbSet<QH_PhieuDenNghiMS_ThietBi> QH_PhieuDenNghiMS_ThietBi { get; set; }
        public virtual DbSet<QH_PhieuGhiTang_ThietBi> QH_PhieuGhiTang_ThietBi { get; set; }
        public virtual DbSet<QH_PhieuGiamTB_ThietBi> QH_PhieuGiamTB_ThietBi { get; set; }
        public virtual DbSet<QH_PhieuMuonPhong_ThietBi> QH_PhieuMuonPhong_ThietBi { get; set; }
        public virtual DbSet<QH_PhieuMuonTB_ThietBi> QH_PhieuMuonTB_ThietBi { get; set; }
        public virtual DbSet<QH_PhieuThanhLyTB_ThietBi> QH_PhieuThanhLyTB_ThietBi { get; set; }
        public virtual DbSet<QH_User_Permission> QH_User_Permission { get; set; }
        public virtual DbSet<TB_PhieuBaoHong> TB_PhieuBaoHong { get; set; }
        public virtual DbSet<TB_PhieuDeNghiMuaSam> TB_PhieuDeNghiMuaSam { get; set; }
        public virtual DbSet<TB_PhieuGiamTB> TB_PhieuGiamTB { get; set; }
        public virtual DbSet<TB_PhieuMuonTB> TB_PhieuMuonTB { get; set; }
        public virtual DbSet<TB_PhieuThanhLyTB> TB_PhieuThanhLyTB { get; set; }
        public virtual DbSet<TB_ThongTinThietBi> TB_ThongTinThietBi { get; set; }
        public virtual DbSet<ThongTinDonVi> ThongTinDonVis { get; set; }
        public virtual DbSet<ThongTinNamHoc> ThongTinNamHocs { get; set; }
        public virtual DbSet<TB_PhieuGhiTang> TB_PhieuGhiTang { get; set; }
        public virtual DbSet<DM_CanBoThietBi> DM_CanBoThietBi { get; set; }
        public virtual DbSet<QH_PhieuSuaTB_ThietBi> QH_PhieuSuaTB_ThietBi { get; set; }
        public virtual DbSet<TB_PhieuSuaTB> TB_PhieuSuaTB { get; set; }
        public virtual DbSet<TB_PhieuMuonPhong> TB_PhieuMuonPhong { get; set; }
        public virtual DbSet<QH_PhieuKiemKe_ThietBi> QH_PhieuKiemKe_ThietBi { get; set; }
        public virtual DbSet<TB_PhieuKiemKe> TB_PhieuKiemKe { get; set; }
        public virtual DbSet<QH_PhieuKiemKe_BanKiemKe> QH_PhieuKiemKe_BanKiemKe { get; set; }
    }
}
