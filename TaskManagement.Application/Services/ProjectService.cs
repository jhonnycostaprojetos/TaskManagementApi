using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Application.DTOs;
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

        //public async Task<IEnumerable<ProjectDTO>> GetAll(int idproject)
        //{
        //    var listEntity = await _projectRepository.SelectAsync();
        //    return _mapper.Map<IEnumerable<ProjectDTO>>(listEntity);
        //    }  
        public async Task<ProjectDTO> Get(int idproject)
        {
            var listEntity = await _projectRepository.SelectAsync(idproject);
            return _mapper.Map<ProjectDTO>(listEntity);
        }

        public Task Post(ProjectDTO userDto)
        {
            throw new NotImplementedException();
        }
    }
}
