using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using webApiAspNetCore.Models;
using webApiAspNetCore.Repository;
using webApiAspNetCore.ViewModel;

namespace webApiAspNetCore.Services.implementation
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _PersonRepository;
        private readonly IMapper _Mapper;

        public PersonService(IPersonRepository PersonRepository, IMapper Mapper)
        {
            _Mapper = Mapper;
            _PersonRepository = PersonRepository;
        }
        public void Add(PersonViewModel person)
        {
            Person p = _Mapper.Map<Person>(person);
            _PersonRepository.Add(p);
            _PersonRepository.Save();
        }

        public void Delete(int id) {
             _PersonRepository.Delete(id);
             _PersonRepository.Save();
        }

        public IEnumerable<PersonViewModel> GetAll()
        {
            var listAllPersons = _PersonRepository.GetAll().Select(x => _Mapper.Map<PersonViewModel>(x));
            return listAllPersons;
        }

        public PersonViewModel GetById(int id) => _Mapper.Map<PersonViewModel>(
                _PersonRepository.GetById(id)); 

        public void Update(PersonViewModel person)
        {
            _PersonRepository.Update(_Mapper.Map<Person>(person));
            _PersonRepository.Save();
        }

    }
}