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
    
    public partial class DM_CanBoThietBi
    {
        public string CanBoThietBiId { get; set; }
        public string HoVaDem { get; set; }
        public string Ten { get; set; }
        public Nullable<int> GioiTinhId { get; set; }
        public Nullable<int> PhuTrachId { get; set; }
        public string TrinhDoVanHoa { get; set; }
        public Nullable<System.DateTime> ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
        public Nullable<bool> IsCoTrinhDoNghiepVu { get; set; }
        public string GhiChu { get; set; }
    
        public virtual DS_GioiTinh DS_GioiTinh { get; set; }
        public virtual DS_PhuTrachCBTB DS_PhuTrachCBTB { get; set; }
    }
}