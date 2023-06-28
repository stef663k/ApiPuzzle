using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;

namespace StortProjectApi.Models;

public class HighscoreModel
{


    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id{ get; set; }

    [BsonElement("Name")]
    public string? PlayerName { get; set; }

    [BsonElement("Score")]
    public int? Score{ get; set; }

}