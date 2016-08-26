using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample.Models
{
    [BsonKnownTypes(typeof(SampleModelWithInheritance))]
    public class SampleModelWithInherianceBase
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class SampleModelWithInheritance : SampleModelWithInherianceBase
    {
        public int Age { get; set; }
    }
}
