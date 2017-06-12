using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class PhieuGiamTBModel
    {
        public string PhieuGiamTBId { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string GhiChu { get; set; }
        public bool IsDelete { get; set; }
        public List<ThietBiGiamGridDisplayModel> ThietBis { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    }
    public class PhieuGiamTBGridDisplayModel
    {
        public string SoPhieu { get; set; }
        public string NgayLap { get; set; }
        public string GhiChu { get; set; }
    }
    public class ThietBiGiamGridDisplayModel : BaseThietBiGridDisplayModel
    {
        public new string ThietBiId { get; set; }
        public new string SoHieu { get; set; }
        public new string Ten { get; set; }
        public new string PhongHoc { get; set; }
        public new string DonViTinh { get; set; }
        public string LoaiThietBi { get; set; }
        public string SoLuongGiam { get; set; }
        public string LyDoGiam { get; set; }
        public string SoPhieuBaoHong { get; set; }
    }
    public class ThietBiGiamDialogModel : BaseThietBiHongGridDisplayModel
    {

    }
    public class ThietBiGiamModel
    {
        public string SoPhieuBaoHong { get; set; }
        public string SoHieu { get; set; }
        public int SoLuongGiam { get; set; }
        public string LyDo { get; set; }
        
    }
}
