using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class DSPhuongXa
    {
        public int PhuongXaId { get; set; }
        public string Ten { get; set; }
        public string Loai { get; set; }
        public string ViTri { get; set; }
        public Nullable<int> QuanHuyenId { get; set; }
    }
}
