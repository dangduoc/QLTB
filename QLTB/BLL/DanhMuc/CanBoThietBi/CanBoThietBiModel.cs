using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class BaseCanBoThietBiModel
    {
        public string CanBoThietBiId { get; set; }
        public string HoVaDem { get; set; }
        public string Ten { get; set; }
    }
    public class CanBoThietBi: BaseCanBoThietBiModel
    {
        public int PhuTrachId { get; set; }
        public string TrinhDoVanHoa { get; set; }
        public DateTime TGBatDauQL { get; set; }
        public DateTime TGKetThucQL { get; set; }
        public bool IsCoTrinhDoNghiepVu { get; set; }
        public string GhiChu { get; set; }
        public int GioiTinhId { get; set; }
    }
    public class CanBoTBGridDisplayModel
    {
        public string CanBoThietBiId { get; set; }
        public string HoVaDem { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public string PhuTrach { get; set; }
        public string TrinhDoVanHoa { get; set; }
        public string TGBatDauQL { get; set; }
        public string TGKetThucQL { get; set; }
        public string IsCoTrinhDoNghiepVu { get; set; }
        public string GhiChu { get; set; }
        
    }
}
