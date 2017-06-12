using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class PhieuSuaTBModel
    {
        public string PhieuSuaTBId { get; set; }
        public System.DateTime NgayLap { get; set; }
        public string GhiChu { get; set; }
        public List<ThietBiSuaGridDisplayModel> ThietBis { get; set; }
        public int CreatedByUserId { get; set; }
        public int UpdatedByUserId { get; set; }
        public System.DateTime CreatedOnDate { get; set; }
        public System.DateTime UpdatedOnDate { get; set; }
    }
    public class PhieuSuaTBGridDisplayModel
    {
        public string PhieuSuaTBId { get; set; }
        public string NgayLap { get; set; }
        public string GhiChu { get; set; }
    }
    public class ThietBiSuaChuaDialogModel:BaseThietBiHongGridDisplayModel
    {
    }
    public class ThietBiSuaGridDisplayModel:BaseThietBiGridDisplayModel
    {
        public new string ThietBiId { get; set; }
        public new string SoHieu { get; set; }
        public new string Ten { get; set; }
        public new string PhongHoc { get; set; }
        public new string DonViTinh { get; set; }
        public string LoaiTB { get; set; }
        public string SoLuongCanSua { get; set; }
        public string GiaTri { get; set; }
        public string DonGiaSua { get; set; }
        public string ThanhTien { get; set; }
        public string TinhTrangHong { get; set; }
        public string MaPhieuHongMat { get; set; }
    }
    public class ThietBiSuaChuaModel
    {
        public int MaPhieuHong { get; set; }
        public string SoHieu { get; set; }
        public int SoLuongSuaChua { get; set; }
        public int DonGiaSua { get; set; }
      
    }
    public class ThietBiSuaDialogModel:BaseThietBiHongGridDisplayModel
    {

    }
}
