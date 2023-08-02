using AutoMapper;
using EventManagmentAPI.Models;
using EventManagmentAPI.DTOs;

namespace EventManagmentAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EventDto, Event>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
