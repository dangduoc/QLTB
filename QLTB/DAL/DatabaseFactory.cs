using QLTB.DAL.Data;
using QLTB.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.DAL
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private readonly Entities dataContext;
        public string Id { get; set; }
        public DatabaseFactory()
        {
           
            dataContext = new Entities();
            dataContext.Database.Connection.ConnectionString = ConnectiongStringBuilder.getConnectionString();
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
