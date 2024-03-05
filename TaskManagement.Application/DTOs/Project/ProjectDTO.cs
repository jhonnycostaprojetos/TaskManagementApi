using TaskManagement.Application.DTOs.TaskProject;
using TaskManagement.Application.DTOs.User;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.DTOs.Project
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
       // public UserDTO User { get; set; }

       // public List<TaskProjectDTO> TaskProject { get; set; }

    }
}
