using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Utils
{
    public class Paging<T> where T : class
    {
        public int Size { get; set; }
        public int CurrentPage { get; set; }
        public bool NextPage { get; set; }
        public bool PreviousPage { get; set; }
        public int TotalRecord { get; set; }
        public T data { get; set; }
    }
    
}
