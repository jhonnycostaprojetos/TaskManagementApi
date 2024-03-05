using TaskManagement.Application.DTOs.Comment;

namespace TaskManagement.Application.DTOs.TaskProject
{
    public class TaskProjectDTOUpdate
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Status { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
