using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample.Mongo
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
