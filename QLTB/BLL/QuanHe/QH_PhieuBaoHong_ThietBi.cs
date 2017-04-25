using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class QH_PhieuBaoHong_ThietBi
    {
        public string PhieuBaoHongId { get; set; }
        public string SoHieuTB { get; set; }
        public int SoLuong { get; set; }
        public string LyDo { get; set; }
        public int TinhTrangId { get; set; }
        public string TinhTrang { get; set; }
    }
    public class QH_PhieuBaoHong_ThietBiModel
    {
        public string PhieuBaoHongId { get; set; }
        public int SoLuong { get; set; }
        public string LyDo { get; set; }
        public int TinhTrangId { get; set; }
        public string TinhTrang { get; set; }
         public ThietBiModel ThietBi { get; set; }
    }
}
