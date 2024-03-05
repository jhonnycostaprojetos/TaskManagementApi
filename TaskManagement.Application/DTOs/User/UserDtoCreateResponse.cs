using TaskManagement.Application.DTOs.Project;

namespace TaskManagement.Application.DTOs.User
{
    public class UserDtoCreateResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreateAt { get; set; }
        public List<ProjectDTO> Projects { get; set; }
    }
}
