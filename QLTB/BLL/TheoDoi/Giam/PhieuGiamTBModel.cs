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
        public string CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public string UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    }
    public class PhieuGiamTBGridDisplayModel
    {
        public string PhieuGiamTBId { get; set; }
        public string NgayLap { get; set; }
        public string GhiChu { get; set; }
    }
    public class ThietBiGiamGridDisplayModel
    {
        public string MaThietBi { get; set; }
        public string Ten { get; set; }
        public string LoaiTB { get; set; }
        public string PhongBM { get; set; }
        public string SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public string LyDoGiam { get; set; }
        public string SoPhieuBaoHong { get; set; }
    }
}
