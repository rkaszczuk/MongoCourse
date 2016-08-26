using MongoCSSample.Mongo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Startup.Configuration();
            var mongoConnection = Startup.Resolve<MongoConnection>();
        }

        
    }
}
