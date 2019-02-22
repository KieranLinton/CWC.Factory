using System;
using MongoDB.Driver;

namespace SM.Mongo.DataBase.Repository
{
    public abstract class MongoDbContext
    {

        public IMongoDatabase Database { get; }

        protected MongoDbContext(string database)
        {
            if (string.IsNullOrWhiteSpace(database))
            {
                throw new ArgumentException(nameof(database));
            }

            var connectionString = "mongodb://localhost/"; 

            var client = new MongoClient(connectionString);
            Database = client.GetDatabase(database);
        }
    }
}
