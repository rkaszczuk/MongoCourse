using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample.Mongo
{
    public class MongoConfiguration
    {
        public static string GetConnectionString()
        {

            return System.Configuration.ConfigurationManager.ConnectionStrings["DefaultMongoConnection"] != null
                && !String.IsNullOrEmpty(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultMongoConnection"].ConnectionString)
                ? System.Configuration.ConfigurationManager.ConnectionStrings["DefaultMongoConnection"].ConnectionString
                : "mongodb://localhost:27017/test";
        }

        public static string GetDbName(string connectionString = null)
        {
            if (!String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings.Get("MongoDbName")))
            {
                return System.Configuration.ConfigurationManager.AppSettings.Get("MongoDbName");
            }
            else if (connectionString != null)
            {
                return MongoUrl.Create(connectionString).DatabaseName;
            }
            else
            {
                return null;
            }
        }
    }
}
