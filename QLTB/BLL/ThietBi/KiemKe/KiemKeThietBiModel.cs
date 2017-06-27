using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class PhieuKiemKeThietBiModel
    {
        public string SoPhieu { get; set; }
        public System.DateTime NgayLap { get; set; }
        public System.DateTime NgayKiemKe { get; set; }
        public int PhongHocId { get; set; }
        public string GhiChu { get; set; }
        public List<BanKiemKeGridDisplayModel> BanKiemKe { get; set; }
        List<ThietBiKKGridDisplayModel> ThietBis { get; set; }
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
        public int VaiTro { get; set; }
    }
    public class ThietBiKKGridDisplayModel
    {
        public string SoPhieu { get; set; }
        public string SoHieu { get; set; }
        public int PhongHocId { get; set; }
        public int SoLuong { get; set; }
        public int DonViTinhId { get; set; }
        public int MatTruoc { get; set; }
        public int MatSau { get; set; }
        public int HongTruoc { get; set; }
        public int HongSau { get; set; }
        public int ConDungDuoc { get; set; }
        public int ChenhLechMat { get; set; }
        public int ChenhLechHong { get; set; }
        public string GhiChu { get; set; }
    }
}
