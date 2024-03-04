using System.ComponentModel.DataAnnotations;
using TaskManagement.Application.DTOs;

namespace TaskManagement.Application.DTOs.User
{
    public class UserDTOCreate
    {
        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}
