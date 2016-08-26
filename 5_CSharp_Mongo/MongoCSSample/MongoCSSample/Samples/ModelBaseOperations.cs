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
    public class ModelBaseOperations
    {
        private IMongoCollection<SampleModel> _mongoCollection;
        public ModelBaseOperations(IMongoCollection<SampleModel> mongoCollection)
        {
            _mongoCollection = mongoCollection;
        }

        public void Insert()
        {
            var rnd = new Random();
            var doc = new SampleModel();
            doc.Name = "Doc2";
            doc.Age = rnd.Next();

            _mongoCollection.InsertOne(doc);
        }

        public void Find()
        {
            var sortBuilder = Builders<SampleModel>.Sort;
            var sort = sortBuilder.Ascending(x=>x.Age);

            var projectionBuilder = Builders<SampleModel>.Projection;
            var projection = projectionBuilder.Exclude(x=>x.Id);

            var result = _mongoCollection.Find(x=>x.Name == "Doc2").Project(projection).Sort(sort).ToList();

            result.ForEach(x => Console.WriteLine(x.ToJson()));

        }
    }
}
