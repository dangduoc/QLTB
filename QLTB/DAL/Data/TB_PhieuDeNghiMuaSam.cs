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
    
    public partial class TB_PhieuDeNghiMuaSam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_PhieuDeNghiMuaSam()
        {
            this.QH_PhieuDenNghiMS_ThietBi = new HashSet<QH_PhieuDenNghiMS_ThietBi>();
        }
    
        public string PhieuDeNghiId { get; set; }
        public string Ten { get; set; }
        public Nullable<int> NamHocId { get; set; }
        public Nullable<int> TrangThaiId { get; set; }
        public string CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public string UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QH_PhieuDenNghiMS_ThietBi> QH_PhieuDenNghiMS_ThietBi { get; set; }
        public virtual ThongTinNamHoc ThongTinNamHoc { get; set; }
    }
}
