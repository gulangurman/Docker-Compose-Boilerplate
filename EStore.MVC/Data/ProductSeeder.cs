using EStore.MVC.Models;
using MongoDB.Driver;

namespace EStore.MVC.Data
{
    public static class ProductSeeder
    {
        public static void Seed(IMongoCollection<Product> products)
        {
            bool exists = products.Find(x => true).Any();
            if (!exists)
            {
                products.InsertManyAsync(GetSeedProducts());
            }
        }
        private static IEnumerable<Product> GetSeedProducts()
        {
            return new List<Product>()
            {
                new Product{ Name="Product A", Summary="Summary A", Description="Description A",
                    Image="A.png", Price=5M, Category="Category 1"
                },
                new Product{ Name="Product B", Summary="Summary B", Description="Description B",
                    Image="B.png", Price=6.05M, Category="Category 2"
                }
            };
        }
    }
}
