using EStore.MVC.Models;
using MongoDB.Driver;

namespace EStore.MVC.Data
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
