using EStore.MVC.Models;
using MongoDB.Driver;

namespace EStore.MVC.Data
{
    public class ProductContext : IProductContext
    {
        public ProductContext(IProductDbSettings settings)
        {
            var client = new MongoClient(connectionString: settings.ConnectionString);
            var database = client.GetDatabase(name: settings.DatabaseName);
            Products = database.GetCollection<Product>(name: settings.CollectionName);
            ProductSeeder.Seed(Products);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
