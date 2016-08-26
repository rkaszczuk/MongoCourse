using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample.Samples
{
    public class BsonDocumentBaseOperations
    {
        private IMongoCollection<BsonDocument> _mongoCollection;
        public BsonDocumentBaseOperations(IMongoCollection<BsonDocument> mongoCollection)
        {
            _mongoCollection = mongoCollection;
        }

        public void Insert()
        {
            var doc = new BsonDocument
            {
                {"Name", "Doc1" },
                {"Age", 30 }
            };

            var options = new InsertOneOptions();

            _mongoCollection.InsertOne(doc);

            var rnd = new Random();
            var doc2 = new BsonDocument();
            doc2.Add("Name", "Doc2");
            doc2.Add("Age", rnd.Next());

            _mongoCollection.InsertOne(doc2);
            
        }

        public void Find()
        {
            var filterBuilder = Builders<BsonDocument>.Filter;
            var filter = filterBuilder.Eq("Name", "Doc2");

            var sortBuilder = Builders<BsonDocument>.Sort;
            var sort = sortBuilder.Ascending("Age");

            var projectionBuilder = Builders<BsonDocument>.Projection;
            var projection = projectionBuilder.Exclude("_id");

            var result = _mongoCollection.Find(filter).Project(projection).Sort(sort).ToList();

            result.ForEach(x => Console.WriteLine(x.ToJson()));

        }

    }
}
