using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample.Mongo
{
    public class MongoConnection
    {
        private string _connectionString;
        private string _dbName;
        private IMongoClient _mongoClient;
        private IMongoDatabase _mongoDb;

        public MongoConnection(string connectionString = null, string dbName = null)
        {
            if (connectionString == null)
            {
                connectionString = MongoConfiguration.GetConnectionString();
            }
            if (dbName == null)
            {
                dbName = MongoConfiguration.GetDbName(connectionString);
            }

            _connectionString = connectionString;
            _dbName = dbName;
        }
        private void Connect()
        {
            _mongoClient = new MongoClient(_connectionString);

            _mongoDb = _mongoClient.GetDatabase(_dbName);
        }

        private bool IsConnected
        {
            get { return _mongoClient != null && _mongoClient.Cluster.Description.State == MongoDB.Driver.Core.Clusters.ClusterState.Connected; }
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            if (!IsConnected)
            {
                Connect();
            }
            if (String.IsNullOrEmpty(collectionName))
            {
                var collectionNameAttribute = typeof(T).GetCustomAttributes(typeof(MongoCollectionNameAttribute), false).FirstOrDefault();
                if (collectionNameAttribute != null)
                {
                    collectionName = ((MongoCollectionNameAttribute)collectionNameAttribute).CollectionName;
                }
                else
                {
                    collectionName = typeof(T).Name;
                }
            }


            return _mongoDb.GetCollection<T>(collectionName);
        }
    }
}
