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
    
    public partial class DS_PhongBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DS_PhongBan()
        {
            this.DM_GiaoVien = new HashSet<DM_GiaoVien>();
        }
    
        public int PhongBanId { get; set; }
        public Nullable<int> CapHocId { get; set; }
        public string Ten { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_GiaoVien> DM_GiaoVien { get; set; }
    }
}
