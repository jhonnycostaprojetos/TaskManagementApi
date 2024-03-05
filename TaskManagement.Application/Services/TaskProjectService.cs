﻿using AutoMapper;
using TaskManagement.Application.DTOs.Project;
using TaskManagement.Application.DTOs.TaskProject;
using TaskManagement.Application.DTOs.User;
using TaskManagement.Application.Interfaces;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
    public class TaskProjectService : ITaskProjectService
    {
        private ITaskProjectRepository _taskprojectRepository;
        private readonly IMapper _mapper;

        public TaskProjectService(ITaskProjectRepository taskprojectRepository, IMapper mapper)
        {
            _mapper = mapper;
            _taskprojectRepository = taskprojectRepository;
        }
        public async Task<TaskProjectDTO> Get(int idproject)
        {
            var listEntity = await _taskprojectRepository.GetAll(idproject);
            return _mapper.Map<TaskProjectDTO>(listEntity);
        }

        public async Task<IEnumerable<TaskProjectDTO>> GetAll(int idproject)
        {
            var listEntity = await _taskprojectRepository.GetAll(idproject);
            return _mapper.Map<IEnumerable<TaskProjectDTO>>(listEntity);
        }

        public async Task<TaskProjectDTOCreateResponse> Post(TaskProjectDTOCreate taskprojectDto)
        {
            var userEntity = _mapper.Map<TaskProject>(taskprojectDto);
            var result = await _taskprojectRepository.InsertAsync(userEntity);

            return _mapper.Map<TaskProjectDTOCreateResponse>(result);
        }

        public async Task<TaskProjectDTOUpdateResponse> Put(TaskProjectDTOUpdate taskProjectDTOUpdate)
        {
            var projectEntity = _mapper.Map<TaskProject>(taskProjectDTOUpdate);

            var result = await _taskprojectRepository.UpdateAsync(projectEntity);
            return _mapper.Map<TaskProjectDTOUpdateResponse>(result);
        }
        public async Task<object> Delete(int id)
        {
            return await _taskprojectRepository.DeleteAsync(id);
        }
    }

}