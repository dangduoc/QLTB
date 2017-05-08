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
        public string CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public string UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public bool IsDelete { get; set; }
    }
    public class PhieuTLGridDisplayModel
    {
        public string SoPhieu { get; set; }
        public string NgayLap { get; set; }
        public string GhiChu { get; set; }
    }
}
