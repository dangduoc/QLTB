using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class DanhSachModel
    {
        private List<TrangThaiTB> trangthaitb = new List<TrangThaiTB>();
        public DanhSachModel()
        {
            trangthaitb.Add(new TrangThaiTB
            {
                Id = 0,
                Name = "Chưa ghi tăng",

            });
            trangthaitb.Add(new TrangThaiTB
            {
                Id = 1,
                Name = "Đã sử dụng",

            });
            trangthaitb.Add(new TrangThaiTB
            {
                Id = -1,
                Name = "Đã xóa",

            });
        }
        public IQueryable<TrangThaiTB> TrangThaiThietBi {
            get {return trangthaitb.AsQueryable(); } set {trangthaitb=value.ToList(); }
        }
    }
    public class TrangThaiTB{
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
