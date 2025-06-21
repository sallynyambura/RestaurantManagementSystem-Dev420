using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Dev420_RestaurantManagementSystem
{
    internal class Reservation
    {
        [BsonId, BsonRepresentation(BsonType.ObjectId)]
        public string ReservationId { get; set; }

        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("reservationName")]
        [BsonRepresentation(BsonType.String)]
        public string ReservationName { get; set; }

        [BsonElement("tableNumber")]
        public int TableNumber { get; set; }

        [BsonElement("reservationDate")]
        public DateTime ReservationDate { get; set; }

        [BsonElement("numberOfPeople")]
        public int NumberOfPeople { get; set; }
    }
}
