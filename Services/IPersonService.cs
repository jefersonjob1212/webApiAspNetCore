using System.Collections.Generic;
using webApiAspNetCore.ViewModel;

namespace webApiAspNetCore.Services
{
    public interface IPersonService
    {
        void Add(PersonViewModel person);
        void Update(PersonViewModel person);
        IEnumerable<PersonViewModel> GetAll();
        PersonViewModel GetById(int id);
        void Delete(int id);
    }
}