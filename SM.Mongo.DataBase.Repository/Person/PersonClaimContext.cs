namespace SM.Mongo.DataBase.Repository.Person
{
    public class PersonClaimContext : MongoDbContext
    {
        public PersonClaimContext(): base("ClientStore")
        {
        }
    }
}
