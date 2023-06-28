using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using StortProjectApi.Configuration;
using StortProjectApi.Model;

namespace StortProjectApi.Services;

public class HighscoreService
{

    //Starter en instans af databasen
    private readonly IMongoCollection<HighscoreModel> _highscoreCollection;

    public HighscoreService(IOptions<DatabaseSettings> databaseSettings)
    {
        var mongoClient = new MongoClient(databaseSettings.Value.ConnectionString);
        var mongoDb = mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);
        _highscoreCollection = mongoDb.GetCollection<HighscoreModel>(databaseSettings.Value.CollectionName);
    }
}