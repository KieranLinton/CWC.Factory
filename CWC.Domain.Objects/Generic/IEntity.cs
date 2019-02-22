namespace CWC.Domain.Objects.Generic
{
    /// <summary>
    /// This is used in the Mongo DB system for T Documents
    /// see MongoDbRepository.cs in SM.Mongo.DataBase.Repository
    /// Every Clain needs this attachted to it.
    /// See CWC.Domain.Objects / PersonClaim
    /// </summary>
    public interface IEntity
    {
        string Id { get; set; }
    }
}
