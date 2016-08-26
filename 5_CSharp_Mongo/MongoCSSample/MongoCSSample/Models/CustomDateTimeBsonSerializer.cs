using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample.Models
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
