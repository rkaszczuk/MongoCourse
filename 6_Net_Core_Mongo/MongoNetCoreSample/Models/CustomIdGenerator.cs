using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample.Models
{
    public class CustomIdGenerator : IIdGenerator
    {
        public object GenerateId(object container, object document)
        {
            var rnd = new Random();
            return rnd.Next(100).ToString();
        }

        public bool IsEmpty(object id)
        {
            return !(id is string && String.IsNullOrEmpty(id as string));
        }
    }
}
