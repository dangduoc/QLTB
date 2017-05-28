using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class PhieuMuonThietBiModel
    {
        public string PhieuMuonTBId { get; set; }
        public string GiaoVienId { get; set; }
        public int MonHocId { get; set; }
        public int KhoiLopId { get; set; }
        public int LopHocId { get; set; }
        public System.DateTime NgayMuon { get; set; }
        public int MuonTuTiet { get; set; }
        public int ThoiGianTrongNgay { get; set; }
        public System.DateTime NgayTra { get; set; }
        public int MucDichSuDungId { get; set; }
        public int SoTiet { get; set; }
        public int BaiDayId { get; set; }
        public bool IsNgoaiQuyDinh { get; set; }
        public int TrangThaiId { get; set; }
        public string GhiChu { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public List<ThietBiMuonGridDisplayModel> ThietBis { get; set; }
    }
    public class PhieuMuonTBGridDisplayModel
    {
        public string PhieuMuonTBId { get; set; }
        public string NgayMuon { get; set; }
        public string NgayTra { get; set; }
        public string BaiDay { get; set; }
        public string LopHoc { get; set; }
        public string GiaoVien { get; set; }
        public string TrangThai { get; set; }
    }
    public class ThietBiMuonModel:BaseThietBiModel
    {
        public short SoLuongMuon { get; set; }
    }
    public class ThietBiMuonGridDisplayModel:BaseThietBiGridDisplayModel
    {
        public new string ThietBiId { get; set; }
        public new string SoHieu { get; set; }
        public new string Ten { get; set; }
        public new string PhongHoc { get; set; }
        public new string DonViTinh { get; set; }
        public string SoLuongMuon { get; set; }
    }
}
