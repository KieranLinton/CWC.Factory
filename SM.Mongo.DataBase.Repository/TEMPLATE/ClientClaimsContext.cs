namespace SM.Mongo.DataBase.Repository.ClientStore
{
    public class ClientClaimsContext : MongoDbContext
    {
        public ClientClaimsContext(): base("ClientStore")
        {
        }
    }
}
