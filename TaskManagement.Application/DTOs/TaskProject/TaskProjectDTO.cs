
using TaskManagement.Application.DTOs.Project;
using TaskManagement.Domain.Enums;

namespace TaskManagement.Application.DTOs.TaskProject
{
    public class TaskProjectDTO
    {
        public int ProjectId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime DueDate { get; private set; }
        public int Status { get; private set; }
        public int Priority { get; private set; }
    }
}
