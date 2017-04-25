using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class PhieuBaoHongModel
    {
        public string PhieuBaoHongId { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string NguoiLamHong { get; set; }
        public string GhiChu { get; set; }
        public string CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public string UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    }
    public class PhieuBaoHongGridDisplayModel
    {
        public string PhieuBaoHongId { get; set; }
        public string NgayLap { get; set; }
        public string NguoiLamHong { get; set; }
        public string GhiChu { get; set; }
    }
    public class PhieuBaoHongCreateModel
    {
        public string PhieuBaoHongId { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string NguoiLamHong { get; set; }
        public string GhiChu { get; set; }
        public string CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
    }
    public class PhieuBaoHongUpdateModel
    {
        public string PhieuBaoHongId { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string NguoiLamHong { get; set; }
        public string GhiChu { get; set; }
        public string UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    }
}
