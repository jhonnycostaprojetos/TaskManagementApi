
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.DTOs
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime CreateAt { get; set; }       

    }
}
