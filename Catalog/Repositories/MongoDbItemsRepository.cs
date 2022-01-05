using Catalog.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Repositories
{
    public class MongoDbItemsRepository : IItemsRepository
    {
        private const string DATABASE_NAME = "catalog";
        private const string COLLECTION_NAME = "items";
        private readonly IMongoCollection<Item> _itemsCollection;

        public MongoDbItemsRepository(IMongoClient mongoClient)
        {
            // Get database
            IMongoDatabase database = mongoClient.GetDatabase(DATABASE_NAME);
            
            // Get collection
            _itemsCollection = database.GetCollection<Item>(COLLECTION_NAME);
        }

        public void CreateItem(Item item)
        {
            _itemsCollection.InsertOne(item);
        }

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
