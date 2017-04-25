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
        public int ThoiGianTrongNgay { get; set; }
        public System.DateTime NgayTra { get; set; }
        public int MucDichSuDungId { get; set; }
        public int SoTiet { get; set; }
        public Nullable<int> BaiDayId { get; set; }
        public bool IsNgoaiQuyDinh { get; set; }
        public int TrangThaiId { get; set; }
        public string GhiChu { get; set; }
        public string CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public string UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    }
    public class PhieuMuonThietBiCreateModel
    {
        public string GiaoVienId { get; set; }
        public int MonHocId { get; set; }
        public int KhoiLopId { get; set; }
        public int LopHocId { get; set; }
        public System.DateTime NgayMuon { get; set; }
        public int ThoiGianTrongNgay { get; set; }
        public System.DateTime NgayTra { get; set; }
        public int MucDichSuDungId { get; set; }
        public int SoTiet { get; set; }
        public Nullable<int> BaiDayId { get; set; }
        public bool IsNgoaiQuyDinh { get; set; }
        public int TrangThaiId { get; set; }
        public string GhiChu { get; set; }
        public string CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
    }
    public class PhieuMuonThietBiUpdateModel
    {
        public string GiaoVienId { get; set; }
        public int MonHocId { get; set; }
        public int KhoiLopId { get; set; }
        public int LopHocId { get; set; }
        public System.DateTime NgayMuon { get; set; }
        public int ThoiGianTrongNgay { get; set; }
        public System.DateTime NgayTra { get; set; }
        public int MucDichSuDungId { get; set; }
        public int SoTiet { get; set; }
        public Nullable<int> BaiDayId { get; set; }
        public bool IsNgoaiQuyDinh { get; set; }
        public int TrangThaiId { get; set; }
        public string GhiChu { get; set; }
        public string UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
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
}
