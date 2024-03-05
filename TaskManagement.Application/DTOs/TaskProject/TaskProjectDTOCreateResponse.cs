namespace TaskManagement.Application.DTOs.TaskProject
{
    public class TaskProjectDTOCreateResponse
    {
        public int Id {  get; set; }
        public int ProjectId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime DueDate { get; private set; }
        public int Status { get; private set; }
        public int Priority { get; private set; }
    }
}
