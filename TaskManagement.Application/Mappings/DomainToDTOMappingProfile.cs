
using AutoMapper;
using TaskManagement.Application.DTOs.Comment;
using TaskManagement.Application.DTOs.Project;
using TaskManagement.Application.DTOs.TaskProject;
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
            CreateMap<Project, ProjectDTOCreate>().ReverseMap();
            CreateMap<Project, ProjectDTOCreateResponse>().ReverseMap();
            CreateMap<Project, ProjectDTOUpdate>().ReverseMap();
            CreateMap<Project, ProjectDTOUpdateResponse>().ReverseMap();

            CreateMap<TaskProject, TaskProjectDTO>().ReverseMap();
            CreateMap<TaskProject, TaskProjectDTOCreate>().ReverseMap();
            CreateMap<TaskProject, TaskProjectDTOCreateResponse>().ReverseMap();
            CreateMap<TaskProject, TaskProjectDTOUpdate>().ReverseMap();
            CreateMap<TaskProject, TaskProjectDTOUpdateResponse>().ReverseMap();

            CreateMap<Comment, CommentDTO>().ReverseMap();

        }
    }
}
