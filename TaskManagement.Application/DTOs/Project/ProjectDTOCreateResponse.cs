namespace TaskManagement.Application.DTOs.Project
{
    public class ProjectDTOCreateResponse
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public int? UserId { get; set; }
    }
}
