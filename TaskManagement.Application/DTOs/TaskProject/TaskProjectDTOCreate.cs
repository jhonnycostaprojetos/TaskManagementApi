using System.ComponentModel.DataAnnotations;
using TaskManagement.Application.DTOs.Comment;

namespace TaskManagement.Application.DTOs.TaskProject
{
    public class TaskProjectDTOCreate
    {
        [Required(ErrorMessage = "The ProjectId is Required")]
        public int ProjectId { get; set; }

        [Required(ErrorMessage = "The Title is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Description is Required")]
        [MinLength(3)]
        [MaxLength(1000)]
        public string Description { get; set; }

        public int Status { get; set; }

        [Required(ErrorMessage = "The Priority is Required")]
        public int Priority { get; set; }

        public DateTime DueDate { get; set; }

    }
}
