using System.ComponentModel.DataAnnotations;


namespace TaskManagement.Application.DTOs.User
{
    public class UserDTO
    {
        public int Id { get; set; }  
        public string? Name { get; set; }
    
        public string? Email { get; set; }

        public List<ProjectDTO> Projects { get; set; }
    }
}
