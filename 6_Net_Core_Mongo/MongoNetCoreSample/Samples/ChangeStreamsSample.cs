using MongoDB.Bson;
using MongoDB.Driver;
using MongoNetCoreSample.Mongo;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MongoNetCoreSample.Samples
{
    public class ChangeStreamsSample
    {
        private MongoConnection mongoConnection;
        public ChangeStreamsSample(MongoConnection mongoConnection)
        {
            this.mongoConnection = mongoConnection;
        }

        public void ChangeStreamOnCollection(string collectionName)
        {
            using (var changeStream = mongoConnection.GetCollection<BsonElement>(collectionName).Watch())
            {
                foreach(var change in changeStream.ToEnumerable())
                {
                    Console.WriteLine(change.ToJson());
                }
            }
        }
        public async void ChangeStreamOnDatabase(string collectionName)
        {
            using (var changeStream = await mongoConnection.GetDatabase().WatchAsync())
            {
                await changeStream.ForEachAsync(change =>
                {
                    Console.WriteLine(change.ToJson());
                });
            }
        }
    }
}
