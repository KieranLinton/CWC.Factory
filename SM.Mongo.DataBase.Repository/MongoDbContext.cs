using System;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using SM.Domain.Objects.Application;

namespace SM.Mongo.DataBase.Repository
{
    public abstract class MongoDbContext
    {
        private readonly IOptions<DataBaseResources> _dataBaseResources;

        public IMongoDatabase Database { get; }

        protected MongoDbContext(string database)
        {
            if (string.IsNullOrWhiteSpace(database))
            {
                throw new ArgumentException(nameof(database));
            }

            var connectionString = "mongodb://localhost/"; //_dataBaseResources.Value.RootDataBase;

            var client = new MongoClient(connectionString);
            Database = client.GetDatabase(database);
        }
    }
}
