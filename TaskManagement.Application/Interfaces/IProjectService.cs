using TaskManagement.Application.DTOs.Project;


namespace TaskManagement.Application.Interfaces
{
    public interface IProjectService
    {
        Task<ProjectDTOCreateResponse> Post(ProjectDTOCreate projectDto);
        Task<ProjectDTO> Get(int idproject);
        Task<IEnumerable<ProjectDTO>> GetAll();
        Task<ProjectDTOUpdateResponse> Put(ProjectDTOUpdate projectDTOUpdate);
        Task<object> Delete(int id);
    }
}
