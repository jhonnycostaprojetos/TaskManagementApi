using TaskManagement.Application.DTOs.Comment;

namespace TaskManagement.Application.Interfaces
{
    public interface ICommentService
    {
        Task<CommentDTOCreateResponse> Post(CommentDTOCreate commentDto);
    }
}
