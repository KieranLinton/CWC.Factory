using System;
using System.Linq;
using System.Threading.Tasks;

namespace CWC.Domain.Objects.Person
{
    public interface IPersonRepository
    {
        Task<PersonClaim> AddPerson(PersonClaim input);
        Task DeletePerson(string id);
        Task<PersonClaim> GetPerson(string id);
        Task QueryPerson(Action<IQueryable<PersonClaim>> success);
        Task UpdatePerson(PersonClaim input);
    }
}