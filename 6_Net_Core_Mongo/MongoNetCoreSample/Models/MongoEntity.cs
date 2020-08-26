using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample.Models
{
    public abstract class MongoEntity : IEntity<string>
    {
        ///Wskazanie reprezentacji property w MongoDB
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
