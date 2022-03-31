﻿using MongoDB.Bson.Serialization.Attributes;

namespace EStore.MVC.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }       
        public string Name { get; set; }        
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
