using AutoMapper;
using TaskManagement.Application.DTOs.Project;
using TaskManagement.Application.Interfaces;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
    public class ProjectService : IProjectService
    {
        private IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public ProjectService(IMapper mapper, IProjectRepository projectRepository)
        {
            _mapper = mapper;
            _projectRepository = projectRepository;
        }

        public async Task<ProjectDTO> Get(int idproject)
        {
            var listEntity = await _projectRepository.SelectAsync(idproject);
            return _mapper.Map<ProjectDTO>(listEntity);
        }

 
        public async Task<ProjectDTOCreateResponse> Post(ProjectDTOCreate projectDto)
        {
            var userEntity = _mapper.Map<Project>(projectDto);
            var result = await _projectRepository.InsertAsync(userEntity);

            return _mapper.Map<ProjectDTOCreateResponse>(result);
        }

        public async Task<IEnumerable<ProjectDTO>> GetAll()
        {
            var listEntity = await _projectRepository.SelectAsync();
            return _mapper.Map<IEnumerable<ProjectDTO>>(listEntity);
        }

        public async Task<ProjectDTOUpdateResponse> Put(ProjectDTOUpdate projectDto)
        {
            var projectEntity = _mapper.Map<Project>(projectDto);

            var result = await _projectRepository.UpdateAsync(projectEntity);
            return _mapper.Map<ProjectDTOUpdateResponse>(result);
        }

        public async Task<object> Delete(int id)
        {
            return await _projectRepository.DeleteAsync(id);
        }
    }
}
