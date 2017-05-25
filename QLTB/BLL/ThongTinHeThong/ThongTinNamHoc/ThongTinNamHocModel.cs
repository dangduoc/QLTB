using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class ThongTinNamHocModel
    {
        public int NamHocId { get; set; }
        public int NamBatDau { get; set; }
        public int NamKetThuc { get; set; }
        public System.DateTime BatDauHK1 { get; set; }
        public System.DateTime BatDauHK2 { get; set; }
        public System.DateTime KetThucNamHoc { get; set; }
        public string GhiChu { get; set; }
        public bool? IsActive { get; set; }
    }
    public class ThongTinNamHocGridModel
    {
        public string NamHocId { get; set; }
        public string ThoiGian { get; set; }
        public string BatDauHK1 { get; set; }
        public string BatDauHK2 { get; set; }
        public string KetThucNamHoc { get; set; }
        public string GhiChu { get; set; }
    }
}
