using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
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
        public static string getConnectionString()
        {
            string PATH = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = "sysconfig.xml";
            string username="", password="", server="", security="", initial="", timeout="";
            using (var reader = XmlReader.Create(Path.Combine(PATH, filename)))
            {

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        //return only when you have START tag

                        switch (reader.Name.ToString())
                        {
                            case "server":
                                server=reader.ReadString();
                                break;
                            case "user":
                                username = reader.ReadString();
                                break;
                            case "password":
                                password = reader.ReadString();
                                break;
                            case "security":
                                security = reader.ReadString();
                                break;
                            case "initial":
                                initial = reader.ReadString();
                                break;
                            case "timeout":
                                timeout = reader.ReadString();
                                break;
                        }
                    } 
                }
            }
            string sqlConnectionString = @"data source=" + server + ";initial catalog=" + initial + ";user id=" + username + ";password=" + password+ ";integrated security="+security+";connection timeout="+timeout+";";
            //EntityConnectionStringBuilder entityString = new EntityConnectionStringBuilder()
            //{
            //    Provider = "System.Data.SqlClient",
            //    Metadata = "res://*/DAL.Data.QLTBContext.csdl|res://*/DAL.Data.QLTBContext.ssdl|res://*/DAL.Data.QLTBContext.msl",
            //    ProviderConnectionString = sqlConnectionString,// sqlString.ToString()
                
            //};
            //return entityString.ConnectionString;
            return sqlConnectionString;
        }
    }
}
