using System;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using SM.Domain.Objects.Clients;
using SM.Domain.Objects.Generics;
using SM.Domain.Objects.Interfaces;
using SM.Domain.Objects.Transformations;

namespace SM.Mongo.DataBase.Repository.ClientStore
{
    public class ClientRepository : MongoDbRepository<ClientClaim>, IClientRepository
    {
        protected override string CollectionName => "Customers";

        public ClientRepository() : base(new ClientClaimsContext())
        {

        }
       
        #region /// crud
        public async Task<ClientClaim> GetCustomer(string id)
        {
            return await GetById(id);
        }
        public async Task QueryCustomer(Action<IQueryable<ClientClaim>> success)
        {
            await Query(success);
        }
        public async Task<ClientClaim> AddCustomer(ClientClaim input)
        {
            return await Add(input);
        }
        public async Task UpdateCustomer(ClientClaim input)
        {
            await Update(input);
        }
        public async Task DeleteCustomer(string id)
        {
            await Delete(id);
        }
        #endregion
    }
}
