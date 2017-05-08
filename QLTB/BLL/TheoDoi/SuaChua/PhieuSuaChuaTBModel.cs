using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class PhieuSuaTBGridDisplayModel
    {
        public string SoPhieu { get; set; }
        public string NgayLap { get; set; }
        public string GhiChu { get; set; }
    }
    public class DSThietBiSuaGridDisplayModel
    {
        public string SoHieu { get; set; }
        public string MaThietBi { get; set; }
        public string Ten { get; set; }
        public string LoaiTB { get; set; }
        public string TinhTrang { get; set; }
        public string SoPhieuBaoHong { get; set; }
    }
    public class ThietBiSuaGridDisplayModel
    {
        public string MaThietBi { get; set; }
        public string Ten { get; set; }
        public string LoaiTB { get; set; }
        public string SoHieu { get; set; }
        public string PhongBM { get; set; }
        public string SoLuongCanSua { get; set; }
        public string DonViTinh { get; set; }
        public string GiaTri { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien { get; set; }
    }
}
