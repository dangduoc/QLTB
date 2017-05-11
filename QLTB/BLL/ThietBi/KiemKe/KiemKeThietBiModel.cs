using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    class KiemKeThietBiModel
    {
    }
    public class KiemKeTBGridDisplayModel
    {
        public string SoHieu { get; set; }
        public string NgayLap { get; set; }
        public string NgayKiemKe { get; set; }
        public string GhiChu { get; set; }
    }
    public class BanKiemKeGridDisplayModel
    {
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public string DaiDien { get; set; }
        public string VaiTro { get; set; }
    }
}
