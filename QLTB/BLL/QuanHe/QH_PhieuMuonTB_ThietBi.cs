using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class QH_PhieuMuonTB_ThietBi
    {
        public string PhieuMuonTBId { get; set; }
        public string SoHieuTB { get; set; }
        public int SoLuong { get; set; }
        public bool IsDaTra { get; set; }
        public Nullable<double> TieuHao { get; set; }
        public string TinhTrangKhiTra { get; set; }
    }
    public class QH_PhieuMuonTB_ThietBiModel
    {
        public string PhieuMuonTBId { get; set; }
        public int SoLuong { get; set; }
        public bool IsDaTra { get; set; }
        public Nullable<double> TieuHao { get; set; }
        public string TinhTrangKhiTra { get; set; }
        public ThietBiModel ThietBi { get; set; }
    }
}
