using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class PhongBoMonModel
    {
        public int PhongHocId { get; set; }
        public string Ten { get; set; }
        public Nullable<int> LoaiPhongTNId { get; set; }
        public Nullable<int> MonHocId { get; set; }
        public Nullable<double> DienTich { get; set; }
        public Nullable<short> SoCanBo { get; set; }
        public Nullable<short> NamDuaVaoSD { get; set; }
        public Nullable<bool> IsPhongChucNang { get; set; }
        public Nullable<int> XepLoaiId { get; set; }
    }
    public class PhongBoMonGridDisplayModel
    {
        public string PhongHocId { get; set; }
        public string Ten { get; set; }
        public string LoaiPhongTN { get; set; }
        public string MonHoc { get; set; }
        public string DienTich { get; set; }
        public string SoCanBo { get; set; }
        public string NamDuaVaoSD { get; set; }
        public string IsPhongChucNang { get; set; }
        public string XepLoai { get; set; }
    }
    public class PhongBoMonCreateModel
    {
        public string Ten { get; set; }
        public Nullable<int> LoaiPhongTNId { get; set; }
        public Nullable<int> MonHocId { get; set; }
        public Nullable<double> DienTich { get; set; }
        public Nullable<short> SoCanBo { get; set; }
        public Nullable<short> NamDuaVaoSD { get; set; }
        public Nullable<bool> IsPhongChucNang { get; set; }
        public Nullable<int> XepLoaiId { get; set; }
    }
    public class PhongBoMonUpdateModel
    {
        public string Ten { get; set; }
        public Nullable<int> LoaiPhongTNId { get; set; }
        public Nullable<int> MonHocId { get; set; }
        public Nullable<double> DienTich { get; set; }
        public Nullable<short> SoCanBo { get; set; }
        public Nullable<short> NamDuaVaoSD { get; set; }
        public Nullable<bool> IsPhongChucNang { get; set; }
        public Nullable<int> XepLoaiId { get; set; }
    }
}
