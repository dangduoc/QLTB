using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class NguonKinhPhiModel
    {
        public int NguonKinhPhiId { get; set; }
        public string Ten { get; set; }
        public Nullable<bool> HasChildren { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> NguonNganSachId { get; set; }
        public string GhiChu { get; set; }
    }
}
