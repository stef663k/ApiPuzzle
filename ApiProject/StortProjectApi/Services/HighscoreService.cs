using System;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using StortProjectApi.Models;
using MongoDB.Bson;

namespace StortProjectApi.Services;

public class HighscoreService
{

    //Starter en instans af databasen
    private readonly IMongoCollection<HighscoreModel> _highscoreCollection;

    public HighscoreService(IOptions<DatabaseModel> databaseSettings)
    {
        var mongoClient = new MongoClient(databaseSettings.Value.ConnectionString);
        var mongoDb = mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);
        _highscoreCollection = mongoDb.GetCollection<HighscoreModel>(databaseSettings.Value.CollectionName);
    }

    public async Task CreateHighScore(HighscoreModel model){
        await _highscoreCollection.InsertOneAsync(model);
        return;
    }

   public async Task<List<HighscoreModel>> GetHighScoreList()
{
    try
    {
        return await _highscoreCollection.Find(new BsonDocument()).ToListAsync();
    }
    catch
    {
        throw;
    }
}
}