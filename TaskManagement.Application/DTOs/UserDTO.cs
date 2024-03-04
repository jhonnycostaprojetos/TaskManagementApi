using System.ComponentModel.DataAnnotations;


namespace TaskManagement.Application.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }

        [EmailAddress]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Email { get; set; }
    }
}
