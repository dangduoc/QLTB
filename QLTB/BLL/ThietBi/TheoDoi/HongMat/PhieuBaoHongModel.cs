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
        public System.DateTime NgayLap { get; set; }
        public string NguoiLamHong { get; set; }
        public string GhiChu { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public List<ThietBiHongGridDisplayModel> ThietBis { get; set; }
    }
    public class PhieuBaoHongGridDisplayModel
    {
        public string PhieuBaoHongId { get; set; }
        public string NgayLap { get; set; }
        public string NguoiLamHong { get; set; }
        public string GhiChu { get; set; }
    }
    public class ThietBiHongDialogModel: BaseThietBiModel
    {
        public string SoLuongHong { get; set; }
        public string MonHoc { get; set; }
    }
    public class ThietBiHongGridDisplayModel:BaseThietBiGridDisplayModel
    {
        public new string ThietBiId { get; set; }
        public new string SoHieu { get; set; }
        public new string Ten { get; set; }
        public new string PhongHoc { get; set; }
        public new string DonViTinh { get; set; }
        public string SoLuongMuon { get; set; }
        public string TinhTrang { get; set; }
        public string LyDo { get; set; }
        public string TinhTrangHong { get; set; }
    }
    public class ThietBiHongModel
    {
        public string SoHieu { get; set; }
        public int SoLuongHong { get; set; }
        public string LyDo { get; set; }
        public string TinhTrangHong { get; set; }
        public int TinhTrangId { get; set; }

    }
}
