using CWC.Domain.Objects.Person;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWC.Services.Person
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        #region /// cusomte methods
        public async Task<List<PersonClaim>> GetAllPeople()
        {
            List<PersonClaim> persons = new List<PersonClaim>();

            // get everyone with no query terms
            await _personRepository.QueryPerson(s => { persons = s.ToList(); });

            // or you do this to get all accounts that are not active
            // await _personRepository.QueryPerson(s => { persons = s.Where(n => n.IsActive == false).ToList(); });
            return persons;
        }
        #endregion

        #region /// CRUD
        public async Task<PersonClaim> GetPerson(string index)
        {
            PersonClaim newPerson = await _personRepository.GetPerson(index);
            return newPerson;
        }
        public async Task<PersonClaim> AddPerson(PersonClaim newPerson)
        {
            newPerson = await _personRepository.AddPerson(newPerson);
            return newPerson;
        }
        public async Task UpdatePerson(PersonClaim newPerson)
        {
            await _personRepository.UpdatePerson(newPerson);
        }
        public async Task DeletePerson(string index)
        {
            await _personRepository.DeletePerson(index);
        }
        #endregion
    }
}
