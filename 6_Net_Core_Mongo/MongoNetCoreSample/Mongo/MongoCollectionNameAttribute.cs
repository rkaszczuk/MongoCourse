using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample.Mongo
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MongoCollectionNameAttribute : Attribute
    {
        public string CollectionName { get; set; }
        public MongoCollectionNameAttribute(string collectionName)
        {
            CollectionName = collectionName;
        }
    }
}
