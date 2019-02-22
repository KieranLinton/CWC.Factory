using System;
using System.Linq;
using System.Threading.Tasks;
using CWC.Domain.Objects.Person;

namespace SM.Mongo.DataBase.Repository.Person
{
    public class PersonRepository : MongoDbRepository<PersonClaim>, IPersonRepository
    {
        protected override string CollectionName => "Persons";
        public PersonRepository() : base(new PersonClaimContext())
        {
        }

        #region /// custome methods

        #endregion

        #region /// CRUD
        public async Task<PersonClaim> GetPerson(string id)
        {
            return await GetById(id);
        }
        public async Task QueryPerson(Action<IQueryable<PersonClaim>> success)
        {
            await Query(success);
        }
        public async Task<PersonClaim> AddPerson(PersonClaim input)
        {
            return await Add(input);
        }
        public async Task UpdatePerson(PersonClaim input)
        {
            await Update(input);
        }
        public async Task DeletePerson(string id)
        {
            await Delete(id);
        }
        #endregion
    }
}
