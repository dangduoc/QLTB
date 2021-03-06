﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class PhieuMuonPhongModel
    {
        public string PhieuMuonPhongId { get; set; }
        public string GiaoVienId { get; set; }
        public int MonHocId { get; set; }
        public int PhongBoMonId { get; set; }
        public int BaiDayId { get; set; }
        public int KhoiLopId { get; set; }
        public int LopHocId { get; set; }
        public int SoTiet { get; set; }
        public int ThoiGianTrongNgay { get; set; }
        public int MuonTuTiet { get; set; }
        public System.DateTime NgayMuon { get; set; }
        public System.DateTime NgayTra { get; set; }
        public bool IsSuDungCaNgay { get; set; }
        public int MucDichSDId { get; set; }
        public bool IsNgoaiQuyDinh { get; set; }
        public bool IsSuDungChoGD { get; set; }
        public Nullable<int> TrangThaiId { get; set; }
        public string GhiChu { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public List<ThietBiMuonGridDisplayModel> ThietBis { get; set; }
    }
    public class PhieuMuonPhongGridDisplayModel
    {
        public string PhieuMuonPhongId { get; set; }
        public string NgayMuon { get; set; }
        public string SoTiet { get; set; }
        public string BaiDay { get; set; }
        public string MonHoc { get; set; }
        public string LopHoc { get; set; }
        public string GiaoVien { get; set; }
        public string TrangThai { get; set; }
    }
    public class PhieuMuonPhongCreateModel
    {
        public string GiaoVienId { get; set; }
        public int MonHocId { get; set; }
        public int PhongBoMonId { get; set; }
        public int BaiDayId { get; set; }
        public int KhoiLopId { get; set; }
        public int LopHocId { get; set; }
        public int SoTiet { get; set; }
        public System.DateTime NgayMuon { get; set; }
        public System.DateTime NgayTra { get; set; }
        public bool IsSuDungCaNgay { get; set; }
        public int MucDichSDId { get; set; }
        public bool IsNgoaiQuyDinh { get; set; }
        public bool IsSuDungChoGD { get; set; }
        public Nullable<int> TrangThaiId { get; set; }
        public string GhiChu { get; set; }
        public string CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
    }
    public class PhieuMuonPhongUpdateModel
    {
        public string GiaoVienId { get; set; }
        public int MonHocId { get; set; }
        public int PhongBoMonId { get; set; }
        public int BaiDayId { get; set; }
        public int KhoiLopId { get; set; }
        public int LopHocId { get; set; }
        public int SoTiet { get; set; }
        public System.DateTime NgayMuon { get; set; }
        public System.DateTime NgayTra { get; set; }
        public bool IsSuDungCaNgay { get; set; }
        public int MucDichSDId { get; set; }
        public bool IsNgoaiQuyDinh { get; set; }
        public bool IsSuDungChoGD { get; set; }
        public Nullable<int> TrangThaiId { get; set; }
        public string GhiChu { get; set; }
        public string UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    }
}
