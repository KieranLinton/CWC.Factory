using System.Collections.Generic;
using System.Threading.Tasks;
using CWC.Domain.Objects.Person;

namespace CWC.Domain.Objects.Person
{
    public interface IPersonService
    {
        Task<PersonClaim> AddPerson(PersonClaim newPerson);
        Task DeletePerson(string index);
        Task<List<PersonClaim>> GetAllPeople();
        Task<PersonClaim> GetPerson(string index);
        Task UpdatePerson(PersonClaim newPerson);
    }
}