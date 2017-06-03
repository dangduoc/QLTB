using QLTB.DAL;
using QLTB.Handler;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QLTB.Utils
{
    public static class ConnectiongStringBuilder
    {
        //public static string getConnectionString()
        //{
        //    string PATH = Path.GetDirectoryName(Application.ExecutablePath);
        //    string filename = "sysconfig.xml";
        //    string username="", password="", server="", security="", initial="", timeout="";
        //    using (var reader = XmlReader.Create(Path.Combine(PATH, filename)))
        //    {

        //        while (reader.Read())
        //        {
        //            if (reader.IsStartElement())
        //            {
        //                //return only when you have START tag

        //                switch (reader.Name.ToString())
        //                {
        //                    case "server":
        //                        server=reader.ReadString();
        //                        break;
        //                    case "user":
        //                        username = reader.ReadString();
        //                        break;
        //                    case "password":
        //                        password = reader.ReadString();
        //                        break;
        //                    case "security":
        //                        security = reader.ReadString();
        //                        break;
        //                    case "initial":
        //                        initial = reader.ReadString();
        //                        break;
        //                    case "timeout":
        //                        timeout = reader.ReadString();
        //                        break;
        //                }
        //            } 
        //        }
        //    }
        //    string sqlConnectionString = @"data source=" + server + ";initial catalog=" + initial + ";user id=" + username + ";password=" + password+ ";integrated security="+security+";connection timeout="+timeout+";";
        //    //EntityConnectionStringBuilder entityString = new EntityConnectionStringBuilder()
        //    //{
        //    //    Provider = "System.Data.SqlClient",
        //    //    Metadata = "res://*/DAL.Data.QLTBContext.csdl|res://*/DAL.Data.QLTBContext.ssdl|res://*/DAL.Data.QLTBContext.msl",
        //    //    ProviderConnectionString = sqlConnectionString,// sqlString.ToString()
                
        //    //};
        //    //return entityString.ConnectionString;
        //    return sqlConnectionString;
        //}
        public static bool CheckDataFile(out string connectionString)
        {
            string PATH = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = "sysconfig.xml";
            string root = "", data = "", dotnetcheck = "";
            using (var reader = XmlReader.Create(Path.Combine(PATH, filename)))
            {

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        //return only when you have START tag

                        switch (reader.Name.ToString())
                        {
                            case "root":
                                root = reader.ReadString();
                                break;
                            case "data":
                                data = reader.ReadString();
                                break;
                            case "dotnetcheck":
                                dotnetcheck = reader.ReadString();
                                break;                  
                        }
                    }
                }
            }
            string sqlConnectionString = @"Data Source=" + Path.Combine(Directory.GetParent(PATH).FullName, data);
            if (File.Exists(Path.Combine(Directory.GetParent(PATH).FullName, data)))
            {
                connectionString = sqlConnectionString;
                return true;
            }
            //return @"data source=(LocalDB)\V11.0;attachdbfilename=" + root + @"\Data\QLTB.mdf;initial catalog=QLTB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            connectionString = sqlConnectionString;
            return false;
        }
        public static bool CheckConnection()
        {
            try
            {
                using (var unitofwork= new UnitOfWork())
                {
                    unitofwork.DataContext.Database.Connection.Open();
                    unitofwork.DataContext.Database.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool CheckUserSaved()
        {
            string PATH = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = "sysconfig.xml";
            string userid = "";
            using (var reader = XmlReader.Create(Path.Combine(PATH, filename)))
            {

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        //return only when you have START tag

                        switch (reader.Name.ToString())
                        {
                            case "userid":
                                userid = reader.ReadString();
                                break;
                           
                        }
                    }
                }
            }
            if (!string.IsNullOrEmpty(userid))
            {
                int id=-1;
                int.TryParse(userid, out id);
                if (id != -1)
                {
                    var workingUser = new LoginHandler().CheckUserSaved(Convert.ToInt32(userid));
                    if (workingUser!=null)
                    {
                        GlobalVariable.SetUser(workingUser);
                        return true;
                    }
                }
                
            }
       
            return false;
        }
    }
}
