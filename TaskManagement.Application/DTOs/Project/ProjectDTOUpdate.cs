using System.ComponentModel.DataAnnotations;


namespace TaskManagement.Application.DTOs.Project
{
    public class ProjectDTOUpdate
    {
        [Required(ErrorMessage = "Id é campo Obrigatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "UserId é campo Obrigatorio")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "ProjectName é campo obrigatório")]
        public string ProjectName { get; set; }
    }
}
