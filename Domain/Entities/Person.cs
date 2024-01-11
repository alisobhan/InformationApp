using Domain.Base;

namespace Domain.Entities;

public class Person : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string  Address { get; set; }

    private Person()
    {

    }
    public Person(string firstName, string lastName, int age, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Address = address;
    }

    public void Update(Person person)
    {
        FirstName = person.FirstName;
        LastName = person.LastName;
        Age = person.Age;
        Address = person.Address;
    }
}
