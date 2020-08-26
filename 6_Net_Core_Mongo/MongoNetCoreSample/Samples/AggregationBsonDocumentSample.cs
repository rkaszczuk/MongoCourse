using MongoDB.Bson;
using MongoDB.Driver;
using MongoNetCoreSample.Mongo;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample.Samples
{
    public class AggregationBsonDocumentSample
    {
        private IMongoCollection<BsonDocument> mongoCollection;
        public AggregationBsonDocumentSample(MongoConnection mongoConnection)
        {
            mongoCollection = mongoConnection.GetCollection<BsonDocument>("BsonTest");
        }

        public void Aggregation()
        {
            PipelineDefinition<BsonDocument, BsonDocument> pipeline = new BsonDocument[]
            {
                new BsonDocument("$match",new BsonDocument("filterField", 1)),
                new BsonDocument("$project",new BsonDocument("newFieldName", "$filterField"))
            };

            var result = mongoCollection.Aggregate(pipeline).ToList();
        }
    }
}
