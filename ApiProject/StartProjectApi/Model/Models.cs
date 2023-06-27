using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Models{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id{ get; set; }
    [BsonElement("Name")]
    public string? PlayerName { get; set; }
    public int? Score{ get; set; }
}