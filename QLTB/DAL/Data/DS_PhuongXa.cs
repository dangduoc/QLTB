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
    
    public partial class DS_PhuongXa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DS_PhuongXa()
        {
            this.ThongTinDonVis = new HashSet<ThongTinDonVi>();
        }
    
        public int PhuongXaId { get; set; }
        public string Ten { get; set; }
        public string Loai { get; set; }
        public string ViTri { get; set; }
        public Nullable<int> QuanHuyenId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinDonVi> ThongTinDonVis { get; set; }
        public virtual DS_QuanHuyen DS_QuanHuyen { get; set; }
    }
}
