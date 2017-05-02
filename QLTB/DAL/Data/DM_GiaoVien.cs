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
    
    public partial class DM_GiaoVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_GiaoVien()
        {
            this.TB_PhieuMuonPhong = new HashSet<TB_PhieuMuonPhong>();
            this.TB_PhieuMuonTB = new HashSet<TB_PhieuMuonTB>();
        }
    
        public string GiaoVienId { get; set; }
        public string HoVaDem { get; set; }
        public string Ten { get; set; }
        public string TenDayDu { get; set; }
        public int GioiTinhId { get; set; }
        public Nullable<System.DateTime> NgaySinh { get ; set; }
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
    
        public virtual DM_MonHoc DM_MonHoc { get; set; }
        public virtual DS_ChucVuGiaoVien DS_ChucVuGiaoVien { get; set; }
        public virtual DS_DanToc DS_DanToc { get; set; }
        public virtual DS_GioiTinh DS_GioiTinh { get; set; }
        public virtual DS_LoaiHopDong DS_LoaiHopDong { get; set; }
        public virtual DS_LyLuanChinhTri DS_LyLuanChinhTri { get; set; }
        public virtual DS_PhongBan DS_PhongBan { get; set; }
        public virtual DS_QuanLyGiaoDuc DS_QuanLyGiaoDuc { get; set; }
        public virtual DS_QuanLyNhaNuoc DS_QuanLyNhaNuoc { get; set; }
        public virtual DS_TrinhDoChuan DS_TrinhDoChuan { get; set; }
        public virtual DS_TrinhDoChuyenMon DS_TrinhDoChuyenMon { get; set; }
        public virtual DS_ViTriGiaoVien DS_ViTriGiaoVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PhieuMuonPhong> TB_PhieuMuonPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PhieuMuonTB> TB_PhieuMuonTB { get; set; }
    }
}
