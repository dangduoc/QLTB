using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class MonHocModel
    {
        public int MonHocId { get; set; }
        public string MaMonHoc { get; set; }
        public string Ten { get; set; }
        public Nullable<int> LoaiMonHocId { get; set; }
        public Nullable<int> LoaiDanhGiaId { get; set; }
    }
    public class MonHocGridDisplayModel
    {
        public string MonHocId { get; set; } 
        public string Ten { get; set; }
        public string MaMonHoc { get; set; }
        public string LoaiMonHoc { get; set; }
        
        public string LoaiDanhGia { get; set; }
    }
    public class MonHocCreateModel
    {
        public string Ten { get; set; }
        public Nullable<int> LoaiMonHocId { get; set; }
        public Nullable<int> LoaiDanhGiaId { get; set; }
    }
    public class MonHocUpdateModel
    {
        public string Ten { get; set; }
        public Nullable<int> LoaiMonHocId { get; set; }
        public Nullable<int> LoaiDanhGiaId { get; set; }
    }
}
