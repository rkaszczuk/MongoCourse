using MongoDB.Bson;
using MongoDB.Driver;
using MongoNetCoreSample.Models;
using MongoNetCoreSample.Mongo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoNetCoreSample.Samples
{
    class AggregationModelSample
    {
        private IMongoCollection<SampleModel> mongoCollection;
        public AggregationModelSample(MongoConnection mongoConnection)
        {
            mongoCollection = mongoConnection.GetCollection<SampleModel>();
        }
        public void Aggregation()
        {
            var result = mongoCollection.Aggregate()
                .Match(x => x.Age < 50)
                .Project(x => new { x.Name, x.Age })
                .Group(x => x.Name, g => new { Name = g.Key, AvgAge = g.Average(x => x.Age) })
                .SortBy(x => x.AvgAge).ToList();

            result.ForEach(x => Console.WriteLine(x.ToJson()));
        }
    }
}
