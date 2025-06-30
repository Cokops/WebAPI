using MongoDB.Driver;
using System.Diagnostics.Metrics;
using WebAPI.Core;

namespace WebAPI.Infrastructure
{
    public class MongoDataBase
    {
        private readonly IMongoDatabase _database;

        public MongoDataBase(IConfiguration config)
        {
            var client = new MongoClient(config["MongoDBSettings:ConnectionString"]);
            _database = client.GetDatabase(config["MongoDBSettings:DatabaseName"]);
        }

        public IMongoCollection<WorkFile> WorkFile => _database.GetCollection<WorkFile>("IDK");
    }
}
