using System;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using SM.Domain.Objects.Generics;

namespace SM.Mongo.DataBase.Repository
{
  public abstract class MongoDbRepository<TDocument> where TDocument : IEntity
  {
    protected readonly MongoDbContext DbContext;

    protected abstract string CollectionName { get; }

    public IMongoCollection<TDocument> Collection => DbContext.Database.GetCollection<TDocument>(CollectionName);

    protected MongoDbRepository(MongoDbContext dbContext)
    {
      DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public async Task Query(Action<IQueryable<TDocument>> success)
    {
      await Task.Run(delegate
      {
        try
        {
          success(DbContext.Database.GetCollection<TDocument>(CollectionName).AsQueryable());
        }
        catch (Exception exception)
        {
          //
        }
      });
    }
    public async Task<TDocument> GetById(string id)
    {
      return await Collection.Find(x => x.Id.Equals(id)).FirstOrDefaultAsync();
    }
    public async Task<TDocument> Add(TDocument aggregate)
    {
      await Collection.InsertOneAsync(aggregate);
      return aggregate;
    }
    public async Task Update(TDocument aggregate)
    {
      await Collection.ReplaceOneAsync(x => x.Id == aggregate.Id, aggregate);
    }
    public async Task Delete(string id)
    {
      await Collection.DeleteOneAsync(x => x.Id == id);
    }
  }
}
