namespace TaskManagement.Application.DTOs.TaskProject
{
    public class TaskProjectDTOCreateResponse
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
    }
}
