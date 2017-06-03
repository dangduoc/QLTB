using QLTB.DAL.Data;
using QLTB.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB.DAL
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private readonly Entities dataContext;
        public string Id { get; set; }
        public string FileData;
        public DatabaseFactory()
        {

            dataContext = new Entities();
            //if (ConnectiongStringBuilder.CheckDataFile(out FileData))
            //{
            //    dataContext.Database.Connection.ConnectionString = FileData;
            //}
            //else
            //{
            //    MessageBox.Show("Không tìm thấy file data!" + Environment.NewLine + FileData, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.Exit();
            //}

            // Get randomize Id
            var random = new Random(DateTime.Now.Millisecond);
            Id = random.Next(1000000).ToString();
        }

        public Entities GetDbContext()
        {
            return dataContext;
        }
    }
}
