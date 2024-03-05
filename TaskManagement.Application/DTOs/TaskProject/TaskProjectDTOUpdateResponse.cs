namespace TaskManagement.Application.DTOs.TaskProject
{
    public class TaskProjectDTOUpdateResponse
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Status { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
