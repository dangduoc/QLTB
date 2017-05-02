using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class KhoiLopModel
    {
        public int KhoiLopId { get; set; }
        public int CapTruongId { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
    }
    public class KhoiLopGridDisplayModel
    {
        public string CapTruong { get; set; }
        public string KhoiLopId { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
    }
    public class KhoiLopCreateModel
    {
        public int CapTruongId { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
    }
    public class KhoiLopUpdateModel
    {
        public int CapTruongId { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
    }
}
