using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Threading;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            return;
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>() { };

            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        public Person FindByID(long id)
        {
            return new Person()
            {
                Id          = 1,
                FirstName   = "Gustavo",
                LastName    = "Costa",
                Address     = "Rua José Gomes Lira - 397 - Mamonas - MG",
                Gender      = "Male",
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person()
            {
                Id          = IncrementAndGet(),
                FirstName   = "Person Name" + i,
                LastName    = "Person Last Name" + i,
                Address     = "Person Address" + i,
                Gender      = "Male",
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
