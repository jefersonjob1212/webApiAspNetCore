using AutoMapper;
using webApiAspNetCore.Models;
using webApiAspNetCore.ViewModel;

namespace webApiAspNetCore.Mappers
{
    public class MappingProfilesViewModel: Profile
    {
        public MappingProfilesViewModel()
        {
            CreateMap<Person, PersonViewModel>();
        }
        
    }
}