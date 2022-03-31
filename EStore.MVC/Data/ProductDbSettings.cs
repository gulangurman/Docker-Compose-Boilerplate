namespace EStore.MVC.Data
{
    public class ProductDbSettings : IProductDbSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}
