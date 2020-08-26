using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample
{
    public class ConfigurationManager
    {
        private static IConfiguration Configuration;

        private static IConfiguration LoadConfiguration()
        {
            Configuration = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .Build();
            return Configuration;
        }
        public static IConfiguration GetConfiguration(bool forceReload = false)
        {
            if (forceReload)
            {
                LoadConfiguration();
            }
            return Configuration ?? LoadConfiguration();
        }

    }
}
