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
    
    public partial class ThongTinNamHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinNamHoc()
        {
            this.TB_PhieuDeNghiMuaSam = new HashSet<TB_PhieuDeNghiMuaSam>();
        }
    
        public int NamHocId { get; set; }
        public int NamBatDau { get; set; }
        public int NamKetThuc { get; set; }
        public System.DateTime BatDauHK1 { get; set; }
        public System.DateTime BatDauHK2 { get; set; }
        public System.DateTime KetThucNamHoc { get; set; }
        public string GhiChu { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PhieuDeNghiMuaSam> TB_PhieuDeNghiMuaSam { get; set; }
    }
}
