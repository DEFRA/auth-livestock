using MongoDB.Driver;

namespace AuthLivestock.Utils.Mongo;

public interface IMongoDbClientFactory
{
    IMongoClient GetClient();

    IMongoCollection<T> GetCollection<T>(string collection);
}