using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Dev420_RestaurantManagementSystem
{
    public class Order
    {

       
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

      
        [BsonElement("OrderId")]
        public string OrderId { get; set; }

        [BsonElement("UserId")]
        public string UserId { get; set; }

        [BsonElement("Items")]
        public List<ItemOrder> Items { get; set; }

        [BsonElement("OrderDate")]
        public DateTime OrderDate { get; set; }

        [BsonElement("Status")]
        public string Status { get; set; }
    }
}
