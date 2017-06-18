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
    public class Response<T>
    {
        public T Data { get; set; }
        public int SucceedResults { get; set; }
        public int FailedResults { get; set; }
        public string Message { get; set; }
        public List<string> Sheets { get; set; }
        public Response()
        {
            this.SucceedResults = 0;
            this.FailedResults = 0;
            Data = default(T);
            Message = "";
            Sheets = new List<string>();
        }
        public Response(int SucceedResults, int FailedResults, string Message, T Data, List<string> Sheets)
        {
            this.Data = Data;
            this.SucceedResults = SucceedResults;
            this.FailedResults = FailedResults;
            this.Message = Message;
            this.Sheets = Sheets;
        }


    }
}
