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
    
    public partial class TB_PhieuThanhLyTB
    {
        public string PhieuThanhLyTBId { get; set; }
        public string DiaDiem { get; set; }
        public string HoiDongThanhLy { get; set; }
        public string NoiDung { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public Nullable<System.DateTime> NgapLap { get; set; }
    
        public virtual HT_User HT_User { get; set; }
        public virtual HT_User HT_User1 { get; set; }
    }
}
