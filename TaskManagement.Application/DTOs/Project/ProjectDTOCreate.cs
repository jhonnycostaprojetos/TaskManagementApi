using System.ComponentModel.DataAnnotations;


namespace TaskManagement.Application.DTOs.Project
{
    public class ProjectDTOCreate
    {
        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "The UserId is Required")]
        public int UserId { get; set; }


    }
}
