using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MongoDB.Bson;

namespace MongoNetCoreSample.Mongo
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
            var mongoClientSettings = MongoClientSettings.FromConnectionString(_connectionString);
            mongoClientSettings.ClusterConfigurator = cb =>
            {
                cb.Subscribe<MongoDB.Driver.Core.Events.CommandStartedEvent>(ev => Console.WriteLine($"[Mongo DEBUG]{ev.CommandName} {ev.Command.ToJson()}"));
            };

            _mongoClient = new MongoClient(mongoClientSettings);
            _mongoDb = _mongoClient.GetDatabase(_dbName);
        }

        private bool IsConnected
        {
            get { return _mongoClient != null && _mongoClient.Cluster.Description.State == MongoDB.Driver.Core.Clusters.ClusterState.Connected; }
        }

        public IMongoDatabase GetDatabase()
        {
            return _mongoDb;
        }

        public IClientSessionHandle GetClientSession()
        {
            return _mongoClient.StartSession();
        }
        public IMongoCollection<T> GetCollection<T>(string collectionName = null)
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
