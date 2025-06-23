using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Dev420_RestaurantManagementSystem
{
    public class Feedback
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FeedbackId { get; set; }

        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("orderId")]
        public string OrderId { get; set; }

        [BsonElement("rating")]
        public int Rating { get; set; }

        [BsonElement("comment")]
        public string Comment { get; set; }
    }
}
