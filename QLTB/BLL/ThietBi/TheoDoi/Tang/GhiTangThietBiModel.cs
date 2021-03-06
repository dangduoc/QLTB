﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class PhieuTangTBModel
    {
        public string PhieuGhiTangId { get; set; }
        public DateTime NgayLap { get; set; }
        public string ChungTuLienQuan { get; set; }
        public string NoiDung { get; set; }
        public bool? IsDelete { get; set; }
        public List<ThietBiTangGridDisplayModel> ThietBis { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    }
    public class PhieuTangTBGridDisplayModel
    {
        public string PhieuGhiTangId { get; set; }
        public string NgayLap { get; set; }
        public string ChungTuLienQuan { get; set; }
        public string NoiDung { get; set; }
    }
    public class ThietBiTangGridDisplayModel:BaseThietBiGridDisplayModel
    {
        public new string ThietBiId { get; set; }
        public new string SoHieu { get; set; }
        public new string Ten { get; set; }
        public new string PhongHoc { get; set; }
        public new string DonViTinh { get; set; }
        public string SoLuongTang { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien { get; set; }
        public string NguonKinhPhi { get; set; }
    }
    public class ThietBiTangDialogModel:BaseThietBiModel
    {
        
    }
    public class ThietBiTangModel
    {
        public string SoHieu { get; set; }
        public int SoLuongTang { get; set; }
        public double DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public int NguonKinhPhiId { get; set; }
    }
}
