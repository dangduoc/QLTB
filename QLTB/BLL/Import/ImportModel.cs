using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class ImportModel
    {
       
    }
    public class ThietBiImport
    {
        public string ThietBiId { get; set; }
        public string SoHieu { get; set; }
        public string Ten { get; set; }
        public int PhongHocId { get; set; }
        public int MonHocId { get; set; }
        public int DonViTinhId { get; set; }
        public string QuyCachSD { get; set; }
        public int NguonKinhPhiId { get; set; }
        public int NamDuaVaoSD { get; set; }
        public System.DateTime NgayDuaVaoSD { get; set; }
        public int NamTheoDoi { get; set; }
        public int SoLuong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
        public string NuocSanXuat { get; set; }
        public int MucDichSDId { get; set; }
        public bool IsThietBiTuLam { get; set; }
        public Nullable<System.DateTime> NgaySanXuat { get; set; }
        public Nullable<System.DateTime> HanSD { get; set; }
        public string GhiChu { get; set; }
    }
    public class KhoPhongMapping
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class Columnmapping
    {
        public int Index { get; set; }
        public string Ten { get; set; }
    }
    public class ResponseImport
    {
        public ThietBiImport ThietBiFailed { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public ResponseImport()
        {
            ThietBiFailed = null;
            Message = "";
            Status = 0;
        }
    }
}
