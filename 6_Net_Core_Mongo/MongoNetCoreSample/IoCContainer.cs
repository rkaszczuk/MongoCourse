using Autofac;
using MongoNetCoreSample.Mongo;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample
{
    public class IoCContainer
    {
        private static IContainer Container { get; set; }
        public static void BuildContainer()
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
