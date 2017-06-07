using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class ToBoMonModel
    {
        public int ToBoMonId { get; set; }
        public string Ten { get; set; }
        public Nullable<bool> HasChildren { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string GhiChu { get; set; }
        public string MaBoMon { get; set; }

    }
    public class ToBoMonDisplayModel
    {
        public int ToBoMonId { get; set; }
        public string Ten { get; set; }
        public string MaBoMon { get; set; }
        public List<ToBoMonDisplayModel> Children { get; set; }
    }
}
