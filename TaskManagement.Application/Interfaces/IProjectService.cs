using TaskManagement.Application.DTOs;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Interfaces
{
    public interface IProjectService
    {
        Task Post(ProjectDTO userDto);
        //Task<IEnumerable<ProjectDTO>> GetAll(int idproject);
        Task<ProjectDTO> Get(int idproject);
    }
}
