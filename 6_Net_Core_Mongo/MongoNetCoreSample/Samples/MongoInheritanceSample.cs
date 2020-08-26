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
    public class MongoInheritanceSample
    {
        private MongoConnection mongoConnection;
        public MongoInheritanceSample(MongoConnection mongoConnection)
        {
            this.mongoConnection = mongoConnection;
        }

        public void Insert()
        {
            mongoConnection.GetCollection<SampleModelWithInheritanceBase>().InsertOne(new SampleModelWithInheritanceBase() { Name = "Ann" });
            mongoConnection.GetCollection<SampleModelWithInheritance>().InsertOne(new SampleModelWithInheritance() { Name = "Joe", Age = 30 });
        }

        public void Find()
        {
            //_t: "type"
            var sampleModelWithInheritanceBaseResult = mongoConnection.GetCollection<SampleModelWithInheritanceBase>().OfType<SampleModelWithInheritanceBase>().Find(_ => true).ToList();
            var sampleModelWithInheritanceResult = mongoConnection.GetCollection<SampleModelWithInheritance>().OfType<SampleModelWithInheritance>().Find(_ => true).ToList();
        }
    }
}
