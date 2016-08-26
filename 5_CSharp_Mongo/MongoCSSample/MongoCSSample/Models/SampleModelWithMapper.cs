using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample.Models
{
    public class SampleModelWithMapper
    {
        public SampleModelWithMapper(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public string CustomId { get; set; }
        public string Login { get; set; }
        public DateTime LastLogin { get; set; }

        public int Age { get; set; }
        public string Password { get; set; }
        public int WrongPasswordCounter { get; set; }
        public int NotImportantField { get; set; }

        public BsonDocument ExtraData { get; set; }
        public static void RegisterMap()
        {
            BsonClassMap.RegisterClassMap<SampleModelWithMapper>(cm =>
            {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
                cm.MapExtraElementsMember(x => x.ExtraData);
                cm.MapCreator(model => new SampleModelWithMapper(model.Login, model.Password));
                cm.MapIdMember(x => x.CustomId).SetIdGenerator(new CustomIdGenerator());
                cm.UnmapMember(x => x.NotImportantField);
                cm.MapMember(x => x.LastLogin).SetIgnoreIfDefault(true).SetSerializer(new CustomDateTimeBsonSerializer());
                cm.MapMember(x => x.Password).SetElementName("pwd").SetIgnoreIfNull(true);
                cm.MapMember(x => x.WrongPasswordCounter).SetDefaultValue(0);
                cm.MapMember(x => x.Login).SetShouldSerializeMethod(x => (x as SampleModelWithMapper).Login.Length > 3);
                cm.MapMember(x => x.Age).SetSerializer(new CharSerializer(BsonType.String));


            });
        }
    }

}
