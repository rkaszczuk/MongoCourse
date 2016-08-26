using MongoCSSample.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample.Ext
{
    public static class IMongoCollectionExt
    {
        public static async Task<ReplaceOneResult> SaveAsync<T>(this IMongoCollection<T> collection, T entity) where T : MongoEntity
        {
            var replaceOneResult = await collection.ReplaceOneAsync(
                doc => doc.Id == entity.Id,
                entity,
                new UpdateOptions { IsUpsert = true });
            return replaceOneResult;
        }
        public static ReplaceOneResult Save<T>(this IMongoCollection<T> collection, T entity) where T : MongoEntity
        {
            return collection.ReplaceOne(
                doc => doc.Id == entity.Id,
                entity,
                new UpdateOptions { IsUpsert = true });
            
        }
    }
}
