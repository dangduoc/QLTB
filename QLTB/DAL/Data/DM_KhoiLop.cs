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
    
    public partial class DM_KhoiLop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_KhoiLop()
        {
            this.DM_LopHoc = new HashSet<DM_LopHoc>();
            this.TB_PhieuMuonPhong = new HashSet<TB_PhieuMuonPhong>();
            this.TB_PhieuMuonTB = new HashSet<TB_PhieuMuonTB>();
        }
    
        public int KhoiLopId { get; set; }
        public int CapTruongId { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
    
        public virtual DS_CapTruong DS_CapTruong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_LopHoc> DM_LopHoc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PhieuMuonPhong> TB_PhieuMuonPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PhieuMuonTB> TB_PhieuMuonTB { get; set; }
    }
}