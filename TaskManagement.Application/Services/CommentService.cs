using AutoMapper;
using TaskManagement.Application.DTOs.Comment;
using TaskManagement.Application.DTOs.TaskProject;
using TaskManagement.Application.Interfaces;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
    public class CommentService : ICommentService
    {
        private ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentService(ICommentRepository commentRepository, IMapper mapper)
        {
            _mapper = mapper;
            _commentRepository = commentRepository;
        }


        public async Task<CommentDTOCreateResponse> Post(CommentDTOCreate commentDto)
        {
            var commentEntity = _mapper.Map<Comment>(commentDto);
            var result = await _commentRepository.InsertAsync(commentEntity);

            return _mapper.Map<CommentDTOCreateResponse>(result);
        }
    }
}

