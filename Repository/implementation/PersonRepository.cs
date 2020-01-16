using System.Collections.Generic;
using System.Linq;
using webApiAspNetCore.Models;

namespace webApiAspNetCore.Repository.implementation
{
    public class PersonRepository : IPersonRepository
    {
        private psiqueonContext _Context;

        public PersonRepository(psiqueonContext Context)
        {
            _Context = Context;
        }
        public void Add(Person person)
        {
            _Context.Add(person);
        }

        public void Delete(int id)
        {
            Person p = GetById(id);
            _Context.Remove(p);
        }

        public IEnumerable<Person> GetAll()
        {
            return _Context.Set<Person>();
        }

        public Person GetById(int id)
        {
            return _Context.Set<Person>().SingleOrDefault(x => x.Id == id);
        }

        public void Save()
        {
            _Context.SaveChanges();
        }

        public void Update(Person person)
        {
            _Context.Set<Person>().Update(person);
        }
    }
}