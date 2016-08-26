using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample.Models
{
    
    public class SampleModel : MongoEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
