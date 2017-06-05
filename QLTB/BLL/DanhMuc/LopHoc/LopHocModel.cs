using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class LopHocModel
    {
        public int LopHocId { get; set; }
        public int KhoiLopId { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
    }
    public class LopHocGridDisplayModel
    {
        public string KhoiLop { get; set; }
        public string LopHocId { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
    }
    public class LopHocCreateModel
    {
        public int KhoiLopId { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
    }
    public class LopHocUpdateModel
    {
        public int KhoiLopId { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
    }
}
