using MongoDB.Bson;
using MongoDB.Driver;
using MongoNetCoreSample.Mongo;
using MongoNetCoreSample.Samples;
using System;

namespace MongoNetCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IoCContainer.BuildContainer();

            //var bsonDocumentBaseOperationsSample = new BsonDocumentBaseOperationsSample(IoCContainer.Resolve<MongoConnection>());
            //bsonDocumentBaseOperationsSample.Insert();
            //bsonDocumentBaseOperationsSample.Find();

            //var modelBaseOperations = new ModelBaseOperations(IoCContainer.Resolve<MongoConnection>());
            //modelBaseOperations.Insert();
            //modelBaseOperations.Find();

            var mongoInheritanceSample = new MongoInheritanceSample(IoCContainer.Resolve<MongoConnection>());
            mongoInheritanceSample.Insert();
            mongoInheritanceSample.Find();

            //var aggregationModelSample = new AggregationModelSample(IoCContainer.Resolve<MongoConnection>());
            //aggregationModelSample.Aggregation();

            var linqSample = new LinqSample(IoCContainer.Resolve<MongoConnection>());
            linqSample.Insert();
            linqSample.Find();
            linqSample.FindWithProjection();

            var mongoConnection = IoCContainer.Resolve<MongoConnection>();
            using (var clientSession = mongoConnection.GetClientSession())
            {
                clientSession.StartTransaction();
                var mongoCollection = mongoConnection.GetCollection<MongoDB.Bson.BsonDocument>("TransTest");
                mongoCollection.InsertOne(clientSession, new BsonDocument());
                mongoCollection.InsertOne(clientSession, new BsonDocument());
                mongoCollection.Find(clientSession, new BsonDocument());

                clientSession.CommitTransaction();
            }



        }
    }
}
