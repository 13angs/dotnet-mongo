using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Sample.Models
{
    public class Blog
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("blog_id")]
        public string? BlogId { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }
    }
}