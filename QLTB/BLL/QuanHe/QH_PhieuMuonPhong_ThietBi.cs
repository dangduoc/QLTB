using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class QH_PhieuMuonPhong_ThietBi
    {
        public string PhieuMuonPhongId { get; set; }
        public string SoHieuTB { get; set; }
        public Nullable<int> SoLuong { get; set; } 
    }
    public class QH_PhieuMuonPhong_ThietBiModel
    {
        public string PhieuMuonPhongId { get; set; }
        public Nullable<int> SoLuong { get; set; }

        public ThietBiModel ThietBi { get; set; }
    }
}
