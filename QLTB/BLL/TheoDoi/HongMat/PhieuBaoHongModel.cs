using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class PhieuBaoHongModel
    {
        public string PhieuBaoHongId { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string NguoiLamHong { get; set; }
        public string GhiChu { get; set; }
        public string CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public string UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    }
    public class PhieuBaoHongGridDisplayModel
    {
        public string PhieuBaoHongId { get; set; }
        public string NgayLap { get; set; }
        public string NguoiLamHong { get; set; }
        public string GhiChu { get; set; }
    }
    public class DSThietBiHongMatGridDisplayModel
    {
        public string MaThietbi { get; set; }
        public string Ten { get; set; }
        public string SoHieu { get; set; }
        public string DonVitinh { get; set; }
        public string SoLuong { get; set; }
        public string PhongBM { get; set; }
        public string MonHoc { get; set; }
    }
    public class ThietBiHongMatGridDisplayModel
    {
        public string SoHieu { get; set; }
        public string MaThietbi { get; set; }
        public string Ten { get; set; }
        public string PhongBM { get; set; }
        public string SoLuongMuon { get; set; }
        public string DonViTinh { get; set; }
        public string TinhTrang { get; set; }
        public string LyDo { get; set; }
        public string TinhTrangHong { get; set; }
    }
}
