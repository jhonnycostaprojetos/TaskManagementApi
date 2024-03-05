namespace TaskManagement.Application.DTOs.Comment
{
    public class CommentDTOCreateResponse
    {
        public int Id { get; set; }
        public string TaskComment { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
