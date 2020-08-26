using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoNetCoreSample.Mongo;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample.Models
{
    [BsonDiscriminator(Required = true, RootClass = true)]
    [BsonKnownTypes(typeof(SampleModelWithInheritance))]
    [MongoCollectionName("SampleModelWithInheritance")]
    public class SampleModelWithInheritanceBase
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
    }
    public class SampleModelWithInheritance : SampleModelWithInheritanceBase
    {
        public int Age { get; set; }
    }
}
