using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample.Samples
{
    public class AggregationBsonDocumentSample
    {
        private IMongoCollection<BsonDocument> _mongoCollection;
        public AggregationBsonDocumentSample(IMongoCollection<BsonDocument> mongoCollection)
        {
            _mongoCollection = mongoCollection;
        }

        public void Aggregation()
        {
            PipelineDefinition<BsonDocument, BsonDocument> pipeline = new BsonDocument[]
            {
                new BsonDocument("$match",new BsonDocument("filterField", 1)),
                new BsonDocument("$project",new BsonDocument("newFieldName", "$filterField"))
            };

            var result = _mongoCollection.Aggregate(pipeline).ToList();
        }
    }
}
