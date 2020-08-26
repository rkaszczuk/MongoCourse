using MongoDB.Bson;
using MongoDB.Driver;
using MongoNetCoreSample.Mongo;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample.Samples
{
    public class BsonDocumentBaseOperationsSample
    {
        private IMongoCollection<BsonDocument> mongoCollection;
        public BsonDocumentBaseOperationsSample(MongoConnection mongoConnection)
        {
            mongoCollection = mongoConnection.GetCollection<BsonDocument>("BsonTest");
        }

        public void Insert()
        {
            var doc = new BsonDocument
            {
                {"Name", "Doc1" },
                {"Age", 30 }
            };


            mongoCollection.InsertOne(doc);

            var rnd = new Random();
            var doc2 = new BsonDocument();
            doc2.Add("Name", "Doc2");
            doc2.Add("Age", rnd.Next());

            mongoCollection.InsertOne(doc2);

        }

        public void Find()
        {
            var filterBuilder = Builders<BsonDocument>.Filter;
            var filter = filterBuilder.Eq("Name", "Doc2");

            var sortBuilder = Builders<BsonDocument>.Sort;
            var sort = sortBuilder.Ascending("Age");

            var projectionBuilder = Builders<BsonDocument>.Projection;
            var projection = projectionBuilder.Exclude("_id");

            var result = mongoCollection.Find(filter).Project(projection).Sort(sort).ToList();

            result.ForEach(x => Console.WriteLine(x.ToJson()));

        }
    }
}
