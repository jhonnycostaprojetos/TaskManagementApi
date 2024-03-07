using System.ComponentModel.DataAnnotations;


namespace TaskManagement.Application.DTOs.Project
{
    public class ProjectDTOUpdate
    {
        [Required(ErrorMessage = "Id is Required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "UserId is Required")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "ProjectName é is Required")]
        public string ProjectName { get; set; }
    }
}
