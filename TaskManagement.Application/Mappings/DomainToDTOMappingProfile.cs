
using AutoMapper;
using TaskManagement.Application.DTOs;
using TaskManagement.Application.DTOs.User;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserDTOCreate>().ReverseMap();
            CreateMap<User, UserDtoCreateResponse>().ReverseMap();
            CreateMap<Project, ProjectDTO>().ReverseMap();
        }
    }
}
