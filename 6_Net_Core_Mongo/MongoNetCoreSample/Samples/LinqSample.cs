using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoNetCoreSample.Models;
using MongoNetCoreSample.Mongo;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample.Samples
{
    public class LinqSample
    {
        private IMongoCollection<SampleModelWithMapper> mongoCollection;
        public LinqSample(MongoConnection mongoConnection)
        {
            SampleModelWithMapper.RegisterMap();
            mongoCollection = mongoConnection.GetCollection<SampleModelWithMapper>();
        }

        public void Insert()
        {
            var itemToAdd = new SampleModelWithMapper("admin", "admin123");
            itemToAdd.LastLogin = DateTime.Now;
            itemToAdd.ExtraData = new BsonDocument();
            itemToAdd.ExtraData.Add(new BsonElement("CreatedAt", DateTime.Now));
            itemToAdd.ExtraData.Add(new BsonElement("CreatedBy", "rkaszczuk"));
            mongoCollection.InsertOne(itemToAdd);
        }
        public void Find()
        {
            var result = mongoCollection.AsQueryable().Where(x => x.Login == "admin").FirstOrDefault();
            Console.WriteLine(result.ToJson());
        }
        public void FindWithProjection()
        {
            var result = mongoCollection.AsQueryable().Where(x => x.Login == "admin").Select(x=> new { x.Login, x.Password}).FirstOrDefault();
            Console.WriteLine(result.ToJson());
        }
    }
}
