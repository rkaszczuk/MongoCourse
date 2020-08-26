using MongoDB.Driver;
using MongoNetCoreSample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoNetCoreSample.Ext
{
    public static class IMongoCollectionExt
    {
        public static async Task<ReplaceOneResult> SaveAsync<T>(this IMongoCollection<T> collection, T entity) where T : MongoEntity
        {
            var replaceOneResult = await collection.ReplaceOneAsync(
                doc => doc.Id == entity.Id,
                entity,
                new ReplaceOptions { IsUpsert = true });
            return replaceOneResult;
        }
        public static ReplaceOneResult Save<T>(this IMongoCollection<T> collection, T entity) where T : MongoEntity
        {
            return collection.ReplaceOne(
                doc => doc.Id == entity.Id,
                entity,
                new ReplaceOptions { IsUpsert = true });

        }
    }
}
