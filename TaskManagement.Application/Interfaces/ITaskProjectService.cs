using TaskManagement.Application.DTOs.Project;
using TaskManagement.Application.DTOs.TaskProject;

namespace TaskManagement.Application.Interfaces
{
    public interface ITaskProjectService
    { 
        Task<IEnumerable<TaskProjectDTO>> GetAll(int idproject);
        Task<TaskProjectDTOCreateResponse> Post(TaskProjectDTOCreate taskprojectDto);
        Task<TaskProjectDTOUpdateResponse> Put(TaskProjectDTOUpdate cep);
        Task<object> Delete(int id);
    }
}
