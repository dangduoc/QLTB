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
    }
}
