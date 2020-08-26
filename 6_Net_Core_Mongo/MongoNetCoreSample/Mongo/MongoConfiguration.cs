using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample.Mongo
{
    public class MongoConfiguration
    {

        public static string GetConnectionString()
        {           
            return !String.IsNullOrEmpty(ConfigurationManager.GetConfiguration().GetConnectionString("Mongo"))
                ? ConfigurationManager.GetConfiguration().GetConnectionString("Mongo")
                : "mongodb://localhost:27017/test";
        }

        public static string GetDbName(string connectionString = null)
        {
            var mongoSettings = ConfigurationManager.GetConfiguration().GetSection("MongoSettings");
            if (mongoSettings!= null && !String.IsNullOrEmpty(mongoSettings["MongoDbName"]))
            {
                return mongoSettings["MongoDbName"];
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
