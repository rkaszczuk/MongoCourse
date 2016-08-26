using MongoDB.Bson.Serialization.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample.Models
{
    public class CustomMongoConvention
    {
        public static void SetConvention()
        {
            var conventionPack = new ConventionPack();
            conventionPack.AddMemberMapConvention("camelCaseMembers", x => x.SetElementName(char.ToLower(x.ElementName[0]) + x.ElementName.Substring(1)));

            ConventionRegistry.Register("CustomConvention", conventionPack, x => x.Name.ToLower() == "samplemodel");
        }
    }
}
