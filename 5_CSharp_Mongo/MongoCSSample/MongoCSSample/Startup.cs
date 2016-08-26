using Autofac;
using MongoCSSample.Mongo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample
{
    public class Startup
    {
        private static IContainer Container { get; set; }
        public static void Configuration()
        {
            SetAutofacContainer();
        }

        private static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MongoConnection>().AsSelf();
            Container = builder.Build();
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
