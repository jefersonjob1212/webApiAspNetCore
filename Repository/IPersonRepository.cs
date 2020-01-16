using System.Collections.Generic;
using webApiAspNetCore.Models;

namespace webApiAspNetCore.Repository
{
    public interface IPersonRepository
    {
        void Add(Person person);
        void Update(Person person);
        IEnumerable<Person> GetAll();
        Person GetById(int id);
        void Delete(int id);
        void Save();
    }
}