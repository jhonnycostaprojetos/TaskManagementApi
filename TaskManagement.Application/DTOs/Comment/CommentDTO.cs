using TaskManagement.Application.DTOs.User;

namespace TaskManagement.Application.DTOs.Comment
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public string TaskComment { get; set; }
        public int TaskProjectId { get; set; }
        public int IdUser { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
