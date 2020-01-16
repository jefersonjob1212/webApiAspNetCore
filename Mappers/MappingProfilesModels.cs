using AutoMapper;
using webApiAspNetCore.Models;
using webApiAspNetCore.ViewModel;

namespace webApiAspNetCore.Mappers
{
    public class MappingProfilesModels: Profile
    {
        public MappingProfilesModels()
        {
            CreateMap<PersonViewModel, Person>();
        }
        
    }
}