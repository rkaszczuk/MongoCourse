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
    public class ModelBaseOperations
    {
        private IMongoCollection<SampleModel> mongoCollection;
        private MongoConnection mongoConnection;
        public ModelBaseOperations(MongoConnection mongoConnection)
        {
            this.mongoConnection = mongoConnection;
            mongoCollection = mongoConnection.GetCollection<SampleModel>();
        }

        public void Insert()
        {
            var rnd = new Random();
            var doc = new SampleModel();
            doc.Name = "Doc2";
            doc.Age = rnd.Next(100);

            mongoCollection.InsertOne(doc);
        }

        public void InsertWithTransaction()
        {
            var rnd = new Random();
            var doc = new SampleModel();
            doc.Name = "Doc2";
            doc.Age = rnd.Next(100);

            mongoCollection.InsertOne(doc);
        }

        public void Find()
        {
            var sortBuilder = Builders<SampleModel>.Sort;
            var sort = sortBuilder.Ascending(x => x.Age);

            var projectionBuilder = Builders<SampleModel>.Projection;
            var projection = projectionBuilder.Exclude(x => x.Id);

            var result = mongoCollection.Find(x => x.Name == "Doc2").Project(projection).Sort(sort).ToList();
            //db.coll.find({Name : "Doc2"}, {_id : 0}).sort({Age : 1})
            //mongoCollection.AsQueryable().Where(x => x.Name == "Doc2").Select(x => new { x.Name, x.Age });

            result.ForEach(x => Console.WriteLine(x.ToJson()));

        }
    }
}
