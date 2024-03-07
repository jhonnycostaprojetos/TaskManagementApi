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
        private ILogTaskProjectRepository _logTaskprojectRepository;


        public CommentService(ICommentRepository commentRepository, IMapper mapper, ILogTaskProjectRepository logTaskprojectRepository)
        {
            _mapper = mapper;
            _commentRepository = commentRepository;
            _logTaskprojectRepository = logTaskprojectRepository;
        }


        public async Task<CommentDTOCreateResponse> Post(CommentDTOCreate commentDto)
        {
            try
            {
                var commentEntity = _mapper.Map<Comment>(commentDto);

                LogTaskProject logTaskProject = new LogTaskProject(commentDto.TaskProjectId, commentDto.TaskComment, commentDto.UserId);

                await _logTaskprojectRepository.InsertAsync(logTaskProject);

                var result = await _commentRepository.InsertAsync(commentEntity);

                return _mapper.Map<CommentDTOCreateResponse>(result);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}

