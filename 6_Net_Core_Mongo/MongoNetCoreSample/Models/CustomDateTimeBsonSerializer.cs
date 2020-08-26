using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample.Models
{
    public class CustomDateTimeBsonSerializer : SerializerBase<DateTime> //Implementing IBsonSerializer
    {
        public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, DateTime value)
        {
            context.Writer.WriteString(value.ToString());
        }
        public override DateTime Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
        {
            return DateTime.Parse(context.Reader.ReadString());
        }
    }
}
