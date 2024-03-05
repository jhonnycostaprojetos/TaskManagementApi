using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Application.DTOs.Comment
{
    public class CommentDTOCreate
    {
        [Required(ErrorMessage = "The Comment is Required")]
        [MinLength(3)]
        [MaxLength(1000)]
        public string TaskComment { get; set; }

        [Required(ErrorMessage = "The IdTaskProject is Required")]
        public int TaskProjectId { get; set; }
        public int IdUser { get; set; }
    }
}
