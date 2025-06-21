using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Dev420_RestaurantManagementSystem
{
    //Serializable keyword is needed to save and store class in a way that can be easily reconstructed easily when passed across application domains
    [Serializable]
    //change internal class to public class so that it can be accessible from any project or assembly that references it.
    public class User
    {
        // This property maps to the MongoDB document's _id field.
        // [BsonId] marks it as the primary identifier.
        // [BsonElement("_id")] maps it to the "_id" field in MongoDB.
        // [BsonRepresentation(ObjectId)] allows assigning it as a string even though MongoDB stores it as an ObjectId.
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string UserID { get; set; }

        // Maps to the "username" field in MongoDB.
        // BsonRepresentation ensures it's treated as a string in the database.
        [BsonElement("username"), BsonRepresentation(BsonType.String)]
        public string Username { get; set; }

        // Maps to the "password" field in MongoDB
        [BsonElement("password"), BsonRepresentation(BsonType.String)]
        public string Password { get; set; }
        
        //maps to the "email" field in MongoDB
        [BsonElement("email"), BsonRepresentation(BsonType.String)]
        public string Email { get; set; }
       
        //maps to the "role" field in MongoDB
        [BsonElement("role"), BsonRepresentation(BsonType.String)]
        public string Role { get; set; } 

        

    }
}