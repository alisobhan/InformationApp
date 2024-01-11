using Domain.Entities;

namespace Domain.Contracts;

public interface IPersonRepository : IGenericRepository<Person>
{
    Task<IEnumerable<Person>> GetAllPersonsAsync();
    Task<Person> GetPersonByIdAsync(int personId);
    Task<Person> GetPersonWithDetailsAsync(int personId);
    void CreatePerson(Person person);
    void UpdatePerson(Person person);
    void DeletePerson(Person person);
}
