using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample.Models
{
    public class SampleModel : MongoEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
