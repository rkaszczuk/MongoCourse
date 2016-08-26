using MongoCSSample.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample.Samples
{
    public class AggregationModelSample
    {
        private IMongoCollection<SampleModel> _mongoCollection;
        public AggregationModelSample(IMongoCollection<SampleModel> mongoCollection)
        {
            _mongoCollection = mongoCollection;
        }

        public void Aggregation()
        {

            var result = _mongoCollection.Aggregate()
                .Match(x => x.Age > 50)
                .Project(x=> new {Name = x.Name, Age = x.Age })
                .Group(x => x.Name, g => new { Name = g.Key, AvgAge = g.Average(x=>x.Age) })
                .SortBy(x=>x.AvgAge).ToList();
        }
    }
}
