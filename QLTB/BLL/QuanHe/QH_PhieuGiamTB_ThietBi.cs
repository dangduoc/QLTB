using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class QH_PhieuGiamTB_ThietBi
    {
        public string PhieuGiamTBId { get; set; }
        public string SoHieuTB { get; set; }
        public Nullable<int> SoLuong { get; set; }
    }
    public class QH_PhieuGiamTB_ThietBiModel
    {
        public string PhieuGiamTBId { get; set; }
        public ThietBiModel ThietBi { get; set; }
        public Nullable<int> SoLuong { get; set; }
    }
}
