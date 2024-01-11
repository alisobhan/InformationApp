using Domain.Contracts;
using Domain.Entities;
using Infrastructure.Repositories.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories.Persons;

public class PersonRepository : GenericRepository<Person>, IPersonRepository
{
    public PersonRepository(DbContext dbContext) : base(dbContext)
    {
    }

    public void CreatePerson(Person person)
    {
        Create(person);
    }

    public void DeletePerson(Person person)
    {
        Delete(person);
    }

    public async Task<IEnumerable<Person>> GetAllPersonsAsync()
    {
        return await GetAll().OrderByDescending(c=> c.Id).ToListAsync();
    }

    public async Task<Person> GetPersonByIdAsync(int personId)
    {
        return await FindByCondition(c=> c.Id == personId).FirstOrDefaultAsync();
    }

    public Task<Person> GetPersonWithDetailsAsync(int personId)
    {
        return null; // TO DO LATER 
    }

    public void UpdatePerson(Person person)
    {
        Update(person);
    }
}
