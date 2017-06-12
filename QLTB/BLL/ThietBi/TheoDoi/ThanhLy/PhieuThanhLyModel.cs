using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class PhieuThanhLyModel
    {
        public string PhieuThanhLyTBId { get; set; }
        public string DiaDiem { get; set; }
        public string HoiDongThanhLy { get; set; }
        public string NoiDung { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<System.DateTime> NgapLap { get; set; }
        public List<ThietBiTLGridDisplayModel> ThietBis { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }

    }

    public class PhieuTLGridDisplayModel
    {
        public string SoPhieu { get; set; }
        public string NgayLap { get; set; }
        public string GhiChu { get; set; }
    }
    public class ThietBiTLGridDisplayModel : BaseThietBiGridDisplayModel
    {
        public new string ThietBiId { get; set; }
        public new string SoHieu { get; set; }
        public new string Ten { get; set; }
        public new string PhongHoc { get; set; }
        public string SoLuongTL { get; set; }
        public new string DonViTinh { get; set; }
        public string SoPhieuBaoHong { get; set; }
        public string LyDo { get; set; }

    }
    public class ThietBiTLDialogModel : BaseThietBiHongGridDisplayModel
    {

    }
    public class ThietBiThanhLy
    {
        public string SoHieu { get; set; }
        public int SoLuongTL { get; set; }
        public string LyDo { get; set; }
        public string SoPhieuBaoHong { get; set; }
    }
}
