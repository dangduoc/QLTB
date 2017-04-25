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
    public class PhieuGiamTBCreateModel
    {
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string GhiChu { get; set; }
        public string CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
    }
    public class PhieuGiamTBUpdateModel
    {
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string GhiChu { get; set; }
        public string UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    }
}
