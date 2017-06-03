using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class ThietBiTraModel
    {
        public string SoHieu { get; set; }
        public double? TieuHao { get; set; }
        public string TinhTrangKhiTra { get; set; }
    }
    public class PhieuTraTBModel
    {
        public string PhieuMuonId { get; set; }
        public List<ThietBiTraModel> ThietBis { get; set; }
    }
    public class ThietBiTraGridDisplayModel: BaseThietBiGridDisplayModel
    {
        public new string ThietBiId { get; set; }
        public new string SoHieu { get; set; }
        public new string Ten { get; set; }
        public new string PhongHoc { get; set; }
        public new string DonViTinh { get; set; }
        public string SoLuongMuon { get; set; }
        public string TinhTrangKhiTra { get; set; }
        public string TieuHao { get; set; }
    }
    
}
