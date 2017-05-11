using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class ThietBiTraModel
    {
        public string SoHieu { get; set; }
        public double? TieuHao { get; set; }
        public string TinhTrangKhiTra { get; set; }
    }
    public class ThietBiTraGridDisplayModel: BaseThietBiGridDisplayModel
    {
        public string SoLuongMuon { get; set; }
        public string TinhTrangKhiTra { get; set; }
        public string TieuHao { get; set; }
    }
    
}
